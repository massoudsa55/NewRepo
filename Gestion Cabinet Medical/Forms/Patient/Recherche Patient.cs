using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Patient
{
    public partial class Recherche_Patient : DevExpress.XtraEditors.XtraForm
    {
        int _ID_Patient;
        public Recherche_Patient()
        {
            InitializeComponent();
        }

        private void Recherche_Patient_Load(object sender, EventArgs e)
        {
            LoadData();
            GetIdPatient();
            EditableGridControl();
            gridView1.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            #region Events
            btn_New.Click += Button_Click;
            btn_Print.Click += Button_Click;
            btn_SalleAttent.Click += Button_Click;
            pic_RDV.Click += Button_Click;
            txtSearch.TextChanged += Txt_Search_TextChanged;
            txtSearch.MouseHover += Send_Search_MouseHover;
            picSearch.MouseHover += Send_Search_MouseHover;
            txtSearch.MouseLeave += Send_Search_MouseLeave;
            picSearch.MouseLeave += Send_Search_MouseLeave;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            gridView1.RowCellClick += GridView1_RowCellClick;
            gridControl1.KeyDown += GridControl1_KeyDown;
            TSM_AddAttente.Click += ToolStripMenu_Click;
            TSM_Edit.Click += ToolStripMenu_Click;
            TSM_Delete.Click += ToolStripMenu_Click;
            TSM_Print.Click += ToolStripMenu_Click;
            TSM_Details.Click += ToolStripMenu_Click;
            #endregion
            #region RepositoryItem

            RepositoryItemButtonEdit riButton = new RepositoryItemButtonEdit();
            riButton.TextEditStyle = TextEditStyles.HideTextEditor;
            riButton.Buttons[0].Kind = ButtonPredefines.Glyph;
            riButton.Buttons[0].Image = Properties.Resources.add_16px;
            riButton.Buttons.Add(new EditorButton(ButtonPredefines.Glyph));
            riButton.Buttons[1].Image = Properties.Resources.edit_16px;
            riButton.Buttons.Add(new EditorButton(ButtonPredefines.Glyph));
            riButton.Buttons[2].Image = Properties.Resources.Delete_16px;
            riButton.Buttons.Add(new EditorButton(ButtonPredefines.Glyph));
            riButton.Buttons[3].Image = Properties.Resources.print_16px;
            riButton.Buttons.Add(new EditorButton(ButtonPredefines.Glyph));
            riButton.Buttons[4].Image = Properties.Resources.info_16px;
            gridView1.Columns["Action"].Width = 130;
            gridControl1.RepositoryItems.Add(riButton);
            gridView1.Columns["Action"].ColumnEdit = riButton;
            riButton.ButtonPressed += RiButton_ButtonClick;
            #endregion
        }

        void EditableGridControl()
        {
            gridView1.Columns["Action"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Code"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Nom"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Prenom"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["DOB"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Age"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["ID_Sexe"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["ID_Civilite"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["ID_GroupeSanguin"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["ID_SF"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Phone1"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Phone2"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Email"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Address"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Profession"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["Note"].OptionsColumn.AllowEdit = false;
        }

        private void RiButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;
            if (e.Button == btnEdit.Properties.Buttons[0])
                PatientEnAttente();
            if (e.Button == btnEdit.Properties.Buttons[1])
                Edit();
            if (e.Button == btnEdit.Properties.Buttons[2])
                Delete();
            if (e.Button == btnEdit.Properties.Buttons[3])
                Print();
            if (e.Button == btnEdit.Properties.Buttons[4])
                Details();
        }

        private void ToolStripMenu_Click(object sender, EventArgs e)
        {
            var send = sender as ToolStripMenuItem;
            switch (send.Name)
            {
                case "TSM_AddAttente":
                    PatientEnAttente();
                    break;
                case "TSM_Edit":
                    Edit();
                    break;
                case "TSM_Delete":
                    Delete();
                    break;
                case "TSM_Print":
                    Print();
                    break;
                case "TSM_Details":
                    Details();
                    break;
                default:
                    break;
            }
        }

        private void GridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Delete:
                    Delete();
                    break;
                case Keys.F1:
                    PatientEnAttente();
                    break;
                case Keys.F2:
                    Edit();
                    break;
                case Keys.F3:
                    Delete();
                    break;
                case Keys.F4:
                    Details();
                    break;
                default:
                    break;
            }
        }

        private void Edit()
        {
            Nouveau_Patient ptn = new Nouveau_Patient();
            ptn.Text = "Modifier le Patient : " + ptn.GetFirsname(_ID_Patient);
            ptn._ID_Patient = _ID_Patient;
            ptn.EditOrAdd = "Edit";
            ptn.ShowDialog();
            LoadData();
        }

        private void PatientEnAttente()
        {
            var patient = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient);
            if (patient != null)
            {
                if (Master.db.Attende.Any(a => a.ID_Patient == patient.ID_Patient))
                    XtraMessageBox.Show("Cette personne est déjà sur la liste d'attente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                if (XtraMessageBox.Show("voulez vous ajouter ce patient à la salle d'attente ?", "Salle d'attente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    LoadAttente();
                else
                    return;
            }
        }

        public void LoadAttente()
        {
            Fiche_Patient_Attente f = new Fiche_Patient_Attente
            {
                NewOrLoad = "Load"
            };
            f._ID_Patient = _ID_Patient;
            f.ShowDialog();
            LoadData();
        }

        public void Details()
        {
        }

        private void Delete()
        {
            if (_ID_Patient != 0)
            {
                var patient = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient);
                if (patient != null)
                {
                    if (XtraMessageBox.Show("Est ce que vous supprimier cette patient ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Master.db.Patient.Remove(patient);
                        Master.db.SaveChanges();
                        XtraMessageBox.Show("Supprission Succse", "Supprission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                        return;
                }
            }
        }

        private void GridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GetIdPatient();
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetIdPatient();
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

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is SimpleButton sendBTN)
            {
                switch (sendBTN.Name)
                {
                    case "btn_New":
                        New();
                        break;
                    case "btn_Print":
                        Print();
                        break;
                    case "btn_SalleAttent":
                        SalleAttende();
                        break;
                    default:
                        break;
                }
            }
            else if (sender is PictureEdit sendPIC && sendPIC.Name == "pic_RDV")
                RDV();
        }

        public void SalleAttende()
        {
            Salle_d_attente attente = new Salle_d_attente();
            attente.ShowDialog();
        }

        public void Print()
        {
            XtraMessageBox.Show("Button Print", "msg", MessageBoxButtons.OK);
        }

        public void RDV()
        {
            XtraMessageBox.Show("Button RDV", "msg", MessageBoxButtons.OK);
        }

        public void New()
        {
            Nouveau_Patient ptn = new Nouveau_Patient
            {
                EditOrAdd = "Add"
            };
            ptn.ShowDialog();
            LoadData();
        }

        public void GetIdPatient()
        {
            if (gridView1.GetFocusedRowCellValue(nameof(DAL.Patient.ID_Patient)) == null) return;
            var id = int.Parse(gridView1.GetFocusedRowCellValue(nameof(DAL.Patient.ID_Patient)).ToString());
            if (id != 0)
                _ID_Patient = id;
        }

        public void LoadData()
        {
            var query = from patient in Master.db.Patient
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
                            patient.ID_Patient,
                            patient.Code,
                            patient.Nom,
                            patient.Prenom,
                            patient.DOB,
                            patient.Age,
                            ID_Sexe = sexe.Type,
                            ID_Civilite = civilite.Type,
                            ID_GroupeSanguin = groupeSanguin.Type,
                            ID_SF = situatioFam.Type,
                            patient.Phone1,
                            patient.Phone2,
                            patient.Email,
                            Address = patient.Address + " " + daira.NameDaira + " " + wilaya.NameWilaya,
                            patient.Profession,
                            patient.Note
                        };
            gridControl1.DataSource = query.ToList();
        }

        public void Search()
        {
            var query = from patient in Master.db.Patient
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
                        where (patient.Code.Contains(txtSearch.Text) || patient.Nom.Contains(txtSearch.Text)
                        || patient.Prenom.Contains(txtSearch.Text) || patient.DOB.ToString().Contains(txtSearch.Text)
                        || patient.Age.ToString().Contains(txtSearch.Text) || sexe.Type.Contains(txtSearch.Text)
                        || civilite.Type.Contains(txtSearch.Text) || groupeSanguin.Type.Contains(txtSearch.Text)
                        || situatioFam.Type.Contains(txtSearch.Text) || patient.Phone1.Contains(txtSearch.Text)
                        || patient.Phone2.Contains(txtSearch.Text) || patient.Email.Contains(txtSearch.Text)
                        || patient.Address.Contains(txtSearch.Text) || patient.Profession.Contains(txtSearch.Text)
                        || patient.Note.Contains(txtSearch.Text) || daira.NameDaira.Contains(txtSearch.Text)
                        || wilaya.NameWilaya.Contains(txtSearch.Text))
                        select new
                        {
                            patient.ID_Patient,
                            patient.Code,
                            patient.Nom,
                            patient.Prenom,
                            patient.DOB,
                            patient.Age,
                            ID_Sexe = sexe.Type,
                            ID_Civilite = civilite.Type,
                            ID_GroupeSanguin = groupeSanguin.Type,
                            ID_SF = situatioFam.Type,
                            patient.Phone1,
                            patient.Phone2,
                            patient.Email,
                            Address = patient.Address + " " + daira.NameDaira + " " + wilaya.NameWilaya,
                            patient.Profession,
                            patient.Note
                        };
            gridControl1.DataSource = query.ToList();
        }

        // pas utilisée
        private void Recherche_Patient_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Tab:
                    break;
                case Keys.Enter:
                    break;
                case Keys.Escape:
                    break;
                case Keys.Control:
                    break;
                case Keys.Alt:
                    break;
                default:
                    break;
            }
        }
    }
}
