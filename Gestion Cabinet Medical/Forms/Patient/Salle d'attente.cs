using DevExpress.XtraGrid.Views.Grid;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Patient
{
    public partial class Salle_d_attente : DevExpress.XtraEditors.XtraForm
    {
        int _ID_Patient;
        public Salle_d_attente()
        {
            InitializeComponent();
        }

        private void Salle_d_attente_Load(object sender, EventArgs e)
        {
            LoadData();
            txtSearch.MouseHover += Send_Search_MouseHover;
            picSearch.MouseHover += Send_Search_MouseHover;
            txtSearch.MouseLeave += Send_Search_MouseLeave;
            picSearch.MouseLeave += Send_Search_MouseLeave;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btn_Home.Click += Button_Click;
            btn_New.Click += Button_Click;
            btn_Paiement.Click += Button_Click;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            gridView1.Columns["ID_Patient"].Visible = false;
            lbl_NamePatient.Text = GetNamePatient();
            gridView1.RowCellClick += GridView1_RowCellClick;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            if (gridView1.GetFocusedRowCellValue("EtatMaladie").ToString() == "Normal")
                gridView1.Columns["EtatMaladie"].AppearanceCell.BackColor = Color.Green;
            else if (gridView1.GetFocusedRowCellValue("EtatMaladie").ToString() == "Urgent")
                gridView1.Columns["EtatMaladie"].AppearanceCell.BackColor = Color.Orange;
            else if (gridView1.GetFocusedRowCellValue("EtatMaladie").ToString() == "Grave")
                gridView1.Columns["EtatMaladie"].AppearanceCell.BackColor = Color.Red;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            var send = sender as DevExpress.XtraEditors.SimpleButton;
            switch (send.Name)
            {
                case "btn_Home":
                    Home();
                    break;
                case "btn_New":
                    NewAttente();
                    LoadData();
                    break;
                case "btn_Paiement":
                    Paiement();
                    break;
                default:
                    break;
            }
        }

        void Paiement()
        {
        }

        void NewAttente()
        {
            Fiche_Patient_Attente f = new Fiche_Patient_Attente
            {
                NewOrLoad = "New"
            };
            f.ShowDialog();
            LoadData();
        }

        void Home()
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lbl_NamePatient.Text = GetNamePatient();
            lbl_Compture.Text = (e.FocusedRowHandle + 1) + " de " + gridView1.RowCount.ToString();
        }

        private void GridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            lbl_NamePatient.Text = GetNamePatient();
        }

        public void GetIdPatient()
        {
            if (gridView1.GetFocusedRowCellValue(nameof(DAL.Patient.ID_Patient)) == null) return;
            var id = int.Parse(gridView1.GetFocusedRowCellValue(nameof(DAL.Patient.ID_Patient)).ToString());
            if (id != 0)
                _ID_Patient = id;
        }

        public string GetNamePatient()
        {
            GetIdPatient();
            var Firstname = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient).Prenom.ToString();
            var Lastname = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient).Nom.ToString();
            if (Firstname == null || Lastname == null)
                return "";
            return Lastname + " " + Firstname;

        }

        public void LoadData()
        {
            var query = from attende in Master.db.Attende
                        join patient in Master.db.Patient on attende.ID_Patient equals patient.ID_Patient
                        into ptn
                        from patient in ptn.DefaultIfEmpty()
                        join etatMaladie in Master.db.EtatMaladie on attende.ID_EM equals etatMaladie.ID_EM
                        into em
                        from etatMaladie in em.DefaultIfEmpty()
                        join statusAttende in Master.db.StatusAttende on attende.ID_SA equals statusAttende.ID_SA
                        into sa
                        from statusAttende in sa.DefaultIfEmpty()
                        join sexe in Master.db.Sexe on patient.ID_Sexe equals sexe.ID_Sexe
                        into s
                        from sexe in s.DefaultIfEmpty()
                        join civilite in Master.db.Civilite on patient.ID_Civilite equals civilite.ID_Civilite
                        into c
                        from civilite in c.DefaultIfEmpty()
                        join groupeSanguin in Master.db.GroupeSanguin on patient.ID_GroupeSanguin equals groupeSanguin.ID_GroupeSanguin
                        into gs
                        from groupeSanguin in gs.DefaultIfEmpty()
                        join situatioFam in Master.db.SituationFam on patient.ID_SF equals situatioFam.ID_SF
                        into sf
                        from situatioFam in sf.DefaultIfEmpty()
                        join daira in Master.db.Daira on patient.ID_Daira equals daira.ID_Daira
                        into d
                        from daira in d.DefaultIfEmpty()
                        join wilaya in Master.db.Wilaya on daira.ID_Wilaya equals wilaya.ID_Wilaya
                        into w
                        from wilaya in w.DefaultIfEmpty()
                        select new
                        {
                            attende.ID_Patient,
                            patient.Code,
                            patient.Nom,
                            patient.Prenom,
                            patient.Age,
                            patient.Phone1,
                            Sexe = sexe.Type,
                            GroupeSanguin = groupeSanguin.Type,
                            Address = patient.Address + " " + daira.NameDaira + " du " + wilaya.NameWilaya,
                            EtatMaladie = etatMaladie.Type_EM,
                            StatusAttende = statusAttende.Type_SA
                        };
            gridControl1.DataSource = query.ToList();
        }

        public void Search()
        {
            var query = from attende in Master.db.Attende
                        join patient in Master.db.Patient on attende.ID_Patient equals patient.ID_Patient
                        into ptn
                        from patient in ptn.DefaultIfEmpty()
                        join etatMaladie in Master.db.EtatMaladie on attende.ID_EM equals etatMaladie.ID_EM
                        into em
                        from etatMaladie in em.DefaultIfEmpty()
                        join statusAttende in Master.db.StatusAttende on attende.ID_SA equals statusAttende.ID_SA
                        into sa
                        from statusAttende in sa.DefaultIfEmpty()
                        join sexe in Master.db.Sexe on patient.ID_Sexe equals sexe.ID_Sexe
                        into s
                        from sexe in s.DefaultIfEmpty()
                        join groupeSanguin in Master.db.GroupeSanguin on patient.ID_GroupeSanguin equals groupeSanguin.ID_GroupeSanguin
                        into gs
                        from groupeSanguin in gs.DefaultIfEmpty()
                        join daira in Master.db.Daira on patient.ID_Daira equals daira.ID_Daira
                        into d
                        from daira in d.DefaultIfEmpty()
                        join wilaya in Master.db.Wilaya on daira.ID_Wilaya equals wilaya.ID_Wilaya
                        into w
                        from wilaya in w.DefaultIfEmpty()
                        where (patient.Code.Contains(txtSearch.Text) || patient.Nom.Contains(txtSearch.Text)
                        || patient.Prenom.Contains(txtSearch.Text) || patient.Age.ToString().Contains(txtSearch.Text)
                        || patient.Phone1.Contains(txtSearch.Text) || sexe.Type.Contains(txtSearch.Text)
                        || groupeSanguin.Type.Contains(txtSearch.Text) || patient.Address.Contains(txtSearch.Text)
                        || etatMaladie.Type_EM.Contains(txtSearch.Text) || statusAttende.Type_SA.Contains(txtSearch.Text)
                        || daira.NameDaira.Contains(txtSearch.Text) || wilaya.NameWilaya.Contains(txtSearch.Text))
                        select new
                        {
                            attende.ID_Patient,
                            patient.Code,
                            patient.Nom,
                            patient.Prenom,
                            patient.Age,
                            patient.Phone1,
                            Sexe = sexe.Type,
                            GroupeSanguin = groupeSanguin.Type,
                            Address = patient.Address + " " + daira.NameDaira + " du " + wilaya.NameWilaya,
                            EtatMaladie = etatMaladie.Type_EM,
                            StatusAttende = statusAttende.Type_SA
                        };
            gridControl1.DataSource = query.ToList();
        }

        private void Send_Search_MouseLeave(object sender, EventArgs e)
        {
            if ((sender is TextBox sendTXT && sendTXT.Name == "txtSearch") ||
                (sender is DevExpress.XtraEditors.PictureEdit sendPIC && sendPIC.Name == "picSearch"))
                lignSearch.BackColor = Color.Black;
        }

        private void Send_Search_MouseHover(object sender, EventArgs e)
        {
            if ((sender is TextBox sendTXT && sendTXT.Name == "txtSearch") ||
                (sender is DevExpress.XtraEditors.PictureEdit sendPIC && sendPIC.Name == "picSearch"))
                lignSearch.BackColor = Color.Red;
        }
    }
}
