using DevExpress.XtraEditors;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Consultation
{
    public partial class Consultation_Management : XtraForm
    {
        int _ID_Daira;
        int _ID_Sexe;
        int _ID_Civilite;
        int _ID_GroupeSanguin;
        int _ID_SituationFam;
        public int _ID_Patient;
        string _PTN_Nom;
        string _PTN_Prenom;
        DAL.Patient patient;
        public Consultation_Management()
        {
            InitializeComponent();
        }

        private void Consultation_Management_Load(object sender, EventArgs e)
        {
            LoadPatient();
            btn_EditData.Click += Btn_EditData_Click;
            slkp_Patient.CustomDisplayText += Slkp_Patient_CustomDisplayText;
        }

        private void Slkp_Patient_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            int i = 9;
            string code = "";
            SearchLookUpEdit edit = sender as SearchLookUpEdit;
            var ptn = edit.Properties.GetRowByKeyValue(edit.EditValue);
            if (ptn != null)
            {
                while (ptn.ToString()[i] != ',')
                {
                    code += ptn.ToString()[i];
                    i++;
                }
                _ID_Patient = (int?)Master.db.Patient.First(a => a.Code == code).ID_Patient ?? 1;
                _PTN_Nom = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient).Nom;
                _PTN_Prenom = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient).Prenom;
                e.DisplayText = string.Concat(_PTN_Nom, " ", _PTN_Prenom);
                EditData(_ID_Patient);
            }
            

        }

        private void Btn_EditData_Click(object sender, EventArgs e)
        {
            if (!IsDataValide())
                return;
            Edit();
        }

        private void LoadPatient()
        {
            var query = from patient in Master.db.Patient
                        select new
                        {
                            patient.Code,
                            patient.Nom,
                            patient.Prenom,
                            DateNaissance = patient.DOB,
                            patient.Phone1,
                        };
            slkp_Patient.Properties.DataSource = query.ToList();
        }

        public void GetData()
        {
            txt_Code.Text = Master.GetNewCode();
            var sexe = Master.db.Sexe.Select(e => e.Type).ToList();
            var civilite = Master.db.Civilite.Select(e => e.Type).ToList();
            var groupeSanguin = Master.db.GroupeSanguin.Select(e => e.Type).ToList();
            var situationFam = Master.db.SituationFam.Select(e => e.Type).ToList();
            var Daira = Master.db.Daira.Select(e => e.NameDaira).ToList();
            var wilaya = Master.db.Wilaya.Select(e => e.NameWilaya).ToList();
            var Pays = Master.db.Pays.Select(e => e.NamePay).ToList();
            lkp_Sexe.Properties.DataSource = sexe;
            lkp_Civilite.Properties.DataSource = civilite;
            lkp_GroupSanguin.Properties.DataSource = groupeSanguin;
            lkp_SituationFam.Properties.DataSource = situationFam;
            slkp_Daira.Properties.DataSource = Daira;
            slkp_Wilaya.Properties.DataSource = wilaya;
            slkp_Pays.Properties.DataSource = Pays;
        }

        public void EditData(int id)
        {
            GetData();
            if (id == 0)
                return;
            patient = Master.db.Patient.First(a => a.ID_Patient == id);
            if (patient == null)
                return;
            txt_Code.Text = patient.Code;
            txt_Nom.Text = patient.Nom;
            txt_Prenom.Text = patient.Prenom;
            txt_FileDe.Text = patient.FileDe;
            dateEdit_DOB.DateTime = patient.DOB;
            txt_Age.EditValue = patient.Age;
            lkp_Sexe.Text = Master.GetSexe(Convert.ToInt32(patient.ID_Sexe));
            lkp_Civilite.Text = Master.GetCivilite(Convert.ToInt32(patient.ID_Civilite));
            txt_Address.Text = patient.Address;
            if (patient.ID_Daira != 0)
            {
                slkp_Wilaya.Text = Master.GetWilaya(Convert.ToInt32(patient.ID_Daira));
                slkp_Daira.Text = Master.GetDaira(Convert.ToInt32(patient.ID_Daira));
                slkp_Pays.Text = Master.GetPays(Convert.ToInt32(patient.ID_Daira));
            }
            txt_Phon1.Text = patient.Phone1;
            txt_Phon2.Text = patient.Phone2;
            txt_Email.Text = patient.Email;
            lkp_GroupSanguin.Text = Master.GetGroupeSanguin(Convert.ToInt32(patient.ID_GroupeSanguin));
            lkp_SituationFam.Text = Master.GetSituationFam(Convert.ToInt32(patient.ID_SF));
            txt_Prefession.Text = patient.Profession;
            txt_Note.Text = patient.Note;
        }

        public void Edit()
        {
            SetData();
            Master.db.Entry(patient).State = EntityState.Modified;
            Master.db.SaveChanges();
            MessageBox.Show("Edited Succesffuly", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GetIdDaira()
        {
            if (slkp_Daira.EditValue != null && slkp_Daira.Text != string.Empty)
            {
                var id_Daira = (int?)Master.db.Daira.First(a => a.NameDaira == slkp_Daira.Text).ID_Daira ?? 0;
                if (id_Daira > 0)
                    _ID_Daira = id_Daira;
            }
        }

        public void GetIdSexe()
        {
            if (lkp_Sexe.EditValue != null && lkp_Sexe.Text != string.Empty)
            {
                var id_Sexe = (int?)Master.db.Sexe.First(a => a.Type == lkp_Sexe.Text).ID_Sexe ?? 0;
                if (id_Sexe > 0)
                    _ID_Sexe = id_Sexe;
            }
        }

        public void GetIdCivilite()
        {
            if (lkp_Civilite.EditValue != null && lkp_Civilite.Text != string.Empty)
            {
                var id_Civilite = (int?)Master.db.Civilite.First(a => a.Type == lkp_Civilite.Text).ID_Civilite ?? 0;
                if (id_Civilite > 0)
                    _ID_Civilite = id_Civilite;
            }
        }

        public void GetIdGroupeSanguin()
        {
            if (lkp_GroupSanguin.EditValue != null && lkp_GroupSanguin.Text != string.Empty)
            {
                var id_GroupeSanguin = (int?)Master.db.GroupeSanguin.First(a => a.Type == lkp_GroupSanguin.Text).ID_GroupeSanguin ?? 0;
                if (id_GroupeSanguin > 0)
                    _ID_GroupeSanguin = id_GroupeSanguin;
            }
        }

        public void GetIdSituationFam()
        {
            if (lkp_SituationFam.EditValue != null && lkp_SituationFam.Text != string.Empty)
            {
                var id_SituationFam = (int?)Master.db.SituationFam.First(a => a.Type == lkp_SituationFam.Text).ID_SF ?? 0;
                if (id_SituationFam > 0)
                    _ID_SituationFam = id_SituationFam;
            }
        }

        public bool IsDataValide()
        {
            int NumberOfErrors = 0;
            NumberOfErrors += Master.IsTextValide(txt_Code) ? 0 : 1;
            NumberOfErrors += Master.IsTextValide(txt_Nom) ? 0 : 1;
            NumberOfErrors += Master.IsTextValide(txt_Prenom) ? 0 : 1;
            NumberOfErrors += Master.IsTextValide(txt_Phon1) ? 0 : 1;
            NumberOfErrors += Master.IsDateValide(dateEdit_DOB) ? 0 : 1;
            return (NumberOfErrors == 0);
        }

        public void SetData()
        {
            GetIdDaira();
            GetIdSexe();
            GetIdCivilite();
            GetIdGroupeSanguin();
            GetIdSituationFam();
            patient.Code = txt_Code.Text;
            patient.Nom = txt_Nom.Text;
            patient.Prenom = txt_Prenom.Text;
            patient.FileDe = txt_FileDe.Text;
            patient.DOB = dateEdit_DOB.DateTime;
            patient.Age = Convert.ToInt32(txt_Age.EditValue);
            patient.ID_Sexe = _ID_Sexe;
            patient.ID_Civilite = _ID_Civilite;
            patient.Address = txt_Address.Text;
            if (_ID_Daira != 0)
                patient.ID_Daira = _ID_Daira;
            patient.Phone1 = txt_Phon1.Text;
            patient.Phone2 = txt_Phon2.Text;
            patient.Email = txt_Email.Text;
            patient.ID_GroupeSanguin = _ID_GroupeSanguin;
            patient.ID_SF = _ID_SituationFam;
            patient.Profession = txt_Prefession.Text;
            patient.Note = txt_Note.Text;
        }
    }
}
