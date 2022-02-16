using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Patient
{
    public partial class Fiche_Patient_Attente : XtraForm
    {
        public int _ID_Patient;
        public int _ID_EM;
        public int _ID_SA;
        public string NewOrLoad;
        public string Nom;
        public string Prenom;
        DAL.Patient patient;
        DAL.Attende attente;
        public Fiche_Patient_Attente()
        {
            InitializeComponent();
        }

        public void GetIdPatient()
        { 
            if (Prenom != string.Empty || Nom != string.Empty)
            {
                var id_patient = (int?)Master.db.Patient.First(a => a.Nom == Nom || a.Prenom == Prenom).ID_Patient ?? 0;
                if (id_patient > 0)
                    _ID_Patient = id_patient;
            }
        }

        public void GetIdEtatMaladie()
        {
            if (lkp_EM.EditValue != null && lkp_EM.Text != string.Empty)
            {
                var id_em = (int?)Master.db.EtatMaladie.First(a => a.Type_EM == lkp_EM.Text).ID_EM ?? 0;
                if (id_em > 0)
                    _ID_EM = id_em;
            }
        }

        public void GetIDStatusAttente()
        {
            if (lkp_SA.EditValue != null && lkp_SA.Text != string.Empty)
            {
                var id_sa = (int?)Master.db.StatusAttende.First(a => a.Type_SA == lkp_SA.Text).ID_SA ?? 0;
                if (id_sa > 0)
                    _ID_SA = id_sa;
            }
        }

        private void Fiche_Patient_Attente_Load(object sender, EventArgs e)
        {
            switch (NewOrLoad)
            {
                case "New":
                    GetData();
                    break;
                case "Load":
                    GetData(_ID_Patient);
                    break;
                default:
                    break;
            }
            btn_Valid.Click += Btn_Valid_Click;
            btn_Annuler.Click += Btn_Annuler_Click;
            slkp_PTN.EditValueChanged += Slkp_PTN_EditValueChanged;
        }

        private void Slkp_PTN_EditValueChanged(object sender, EventArgs e)
        {
            GridView view = slkp_PTN.Properties.View as GridView;
            Nom = (string)view.GetRowCellValue(view.FocusedRowHandle, nameof(DAL.Patient.Nom));
            Prenom = (string)view.GetRowCellValue(view.FocusedRowHandle, nameof(DAL.Patient.Prenom));
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if (!IsDataValide())
                return;
            switch (NewOrLoad)
            {
                case "New":
                    {
                        GetIdPatient();
                        var patient = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient);
                        if (patient != null)
                        {
                            if (Master.db.Attende.Any(a => a.ID_Patient == patient.ID_Patient))
                                XtraMessageBox.Show("Cette personne est déjà sur la liste d'attente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                Save();
                            Close();
                        }
                    }
                    break;
                case "Load":
                    Save();
                    Close();
                    break;
                default:
                    break;
            }
        }

        public bool IsDataValide()
        {
            int NumberOfErrors = 0;
            NumberOfErrors += Master.IsEditValueValideAndNotZero(slkp_PTN) ? 0 : 1;
            NumberOfErrors += Master.IsEditValueValide(lkp_EM) ? 0 : 1;
            NumberOfErrors += Master.IsEditValueValide(lkp_SA) ? 0 : 1;
            return (NumberOfErrors == 0);
        }
        public void Save()
        {
            SetData();
            Master.db.Attende.Add(attente);
            Master.db.SaveChanges();
            XtraMessageBox.Show("Saved Succesffuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SetData()
        {
            GetIdPatient();
            GetIdEtatMaladie();
            GetIDStatusAttente();
            attente = new DAL.Attende
            {
                ID_Patient = _ID_Patient,
                ID_EM = _ID_EM,
                ID_SA = _ID_SA
            };
        }

        public void GetData()
        {
            GetPatients();
            Get_EM_SA();
        }

        public void GetData(int id)
        {
            if (id == 0)
                return;
            patient = Master.db.Patient.First(a => a.ID_Patient == id);
            if (patient == null)
                return;
            Prenom = Master.GetPrenomPatient(Convert.ToInt32(patient.ID_Patient));
            Nom = Master.GetNomPatient(Convert.ToInt32(patient.ID_Patient));
            string str = Nom + " " + Prenom;
            slkp_PTN.Properties.NullText = str;
            slkp_PTN.ReadOnly = true;
            Get_EM_SA();
        }

        void Get_EM_SA()
        {
            lkp_EM.Properties.DataSource = Master.db.EtatMaladie.Select(a => a.Type_EM).ToList();
            lkp_SA.Properties.DataSource = Master.db.StatusAttende.Select(a => a.Type_SA).ToList();
        }
        void GetPatients()
        {
            var query = from patient in Master.db.Patient
                        join sexe in Master.db.Sexe on patient.ID_Sexe equals sexe.ID_Sexe
                        into s
                        from sexe in s.DefaultIfEmpty()
                        join groupeSanguin in Master.db.GroupeSanguin on patient.ID_GroupeSanguin equals groupeSanguin.ID_GroupeSanguin
                        into gs
                        from groupeSanguin in gs.DefaultIfEmpty()
                        select new
                        {
                            ID = patient.ID_Patient,
                            patient.Code,
                            patient.Nom,
                            patient.Prenom,
                            patient.Age,
                            Sexe = sexe.Type,
                            GroupeSanguin = groupeSanguin.Type,
                        };
            slkp_PTN.Properties.DataSource = query.ToList();
            slkp_PTN.Properties.ValueMember = nameof(DAL.Patient.ID_Patient);
            slkp_PTN.Properties.DisplayMember = nameof(DAL.Patient.Nom);
        }

        private void Fiche_Patient_Attente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Btn_Valid_Click(null, null);
                    break;
                case Keys.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }
    }
}
