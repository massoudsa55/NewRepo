using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
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
        int _ID_Consultation;
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
            this.WindowState = FormWindowState.Maximized;
            LoadPatient();
            DefultTextEdit();
            btn_New.Click += Btn_New_Click;
            btn_Edit.Click += Btn_Edit_Click;
            btn_Delete.Click += Btn_Delete_Click;
            btn_Print.Click += Btn_Print_Click;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            gridView1.RowCellClick += GridView1_RowCellClick;
            toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            #region Evants
            btn_EditData.Click += Btn_EditData_Click;
            slkp_Patient.CustomDisplayText += Slkp_Patient_CustomDisplayText;
            txt_Poids.GotFocus += TextEdit_GotFocus;
            txt_Taille.GotFocus += TextEdit_GotFocus;
            txt_Temperator.GotFocus += TextEdit_GotFocus;
            txt_FCardiaque.GotFocus += TextEdit_GotFocus;
            txt_Glycemie.GotFocus += TextEdit_GotFocus;
            txt_PressionArterielle.GotFocus += TextEdit_GotFocus;
            #endregion

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Btn_Edit_Click(null, null);
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Print();
        }

        public void Print()
        {

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        public void Delete()
        {
            if (gridView1.DataSource == null)
                return;
            DeleteConsultation();

        }

        private void DeleteConsultation()
        {
            if (_ID_Patient != 0)
            {
                var consult = Master.db.Consultations.First(a => a.ID_Consultation == _ID_Consultation);
                if (consult != null)
                {
                    if (XtraMessageBox.Show("Est ce que vous supprimier cette patient ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Master.db.Consultations.Remove(consult);
                        Master.db.SaveChanges();
                        XtraMessageBox.Show("Supprission Succse", "Supprission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadConsultation(_ID_Patient);
                    }
                    else
                        return;
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (gridView1.DataSource == null)
                return;
            Nouvelle_Consultation nouvelle_Consultation = new Nouvelle_Consultation();
            nouvelle_Consultation._ID_Patient = _ID_Patient;
            nouvelle_Consultation.EditOrAdd = "Edit";
            nouvelle_Consultation._ID_Consultation = _ID_Consultation;
            MessageBox.Show("id consultation avant transfre  =  " + _ID_Consultation);
            nouvelle_Consultation.ShowDialog();
            LoadConsultation(_ID_Patient);
        }

        public void GetIdConsultation()
        {
            if (gridView1.GetFocusedRowCellValue(nameof(DAL.Consultations.ID_Consultation)) == null
                || (Master.db.Consultations.Count(a => a.ID_Patient == _ID_Patient) == 0)) return;
            var id = int.Parse(gridView1.GetFocusedRowCellValue(nameof(DAL.Consultations.ID_Consultation)).ToString());
            if (id != 0)
                _ID_Consultation = id;
        }

        private void GridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            GetIdConsultation();
            DefultTextEdit(_ID_Consultation);
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetIdConsultation();
            DefultTextEdit(_ID_Consultation);
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (slkp_Patient.Text == string.Empty)
                MessageBox.Show("Choisire un sule patient s'il vous plait", "msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Nouvelle_Consultation nouvelle_Consultation = new Nouvelle_Consultation();
                nouvelle_Consultation._ID_Patient = _ID_Patient;
                nouvelle_Consultation.EditOrAdd = "New";
                nouvelle_Consultation.ShowDialog();
                LoadConsultation(_ID_Patient);
            }
        }

        private void TextEdit_GotFocus(object sender, EventArgs e)
        {
            if (sender is TextEdit sendTXT)
            {
                switch (sendTXT.Name)
                {
                    case "txt_Poids":
                        ClearTextFromBox(txt_Poids);
                        break;
                    case "txt_Taille":
                        ClearTextFromBox(txt_Taille);
                        break;
                    case "txt_Temperator":
                        ClearTextFromBox(txt_Temperator);
                        break;
                    case "txt_FCardiaque":
                        ClearTextFromBox(txt_FCardiaque);
                        break;
                    case "txt_Glycemie":
                        ClearTextFromBox(txt_Glycemie);
                        break;
                    case "txt_PressionArterielle":
                        ClearTextFromBox(txt_PressionArterielle);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Slkp_Patient_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
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
                _ID_Patient = (int)Master.db.Patient.Where(a => a.Code == code).FirstOrDefault().ID_Patient;
                _PTN_Nom = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient).Nom;
                _PTN_Prenom = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient).Prenom;
                e.DisplayText = string.Concat(_PTN_Nom, " ", _PTN_Prenom);
                if (Master.db.Consultations.Count(a => a.ID_Patient == _ID_Patient) >= 1)
                    _ID_Consultation = (int?)Master.db.Consultations.Select(a => a.ID_Consultation).Max() ?? 1;
                else
                    _ID_Consultation = 1;
                EditData(_ID_Patient);
                LoadConsultation(_ID_Patient);
            }
        }

        public void LoadConsultation(int idPatient)
        {
            DefultTextEdit();
            if (!Master.db.Consultations.Any(a => a.ID_Patient == idPatient))
            {
                gridControl_Consultation.DataSource = null;
                return;
            }
            var idConsult = Master.db.Consultations.Where(a => a.ID_Patient == idPatient).FirstOrDefault().ID_Consultation;
            if (idConsult == 0)
                return;
            DefultTextEdit(idConsult);
            var query = from consult in Master.db.Consultations
                        join paiment in Master.db.Paiement on consult.ID_Consultation equals paiment.ID_Consultation
                        into p
                        from paiment in p.DefaultIfEmpty()
                        join motifs in Master.db.Motifs on consult.ID_Motifs equals motifs.ID_Motifs
                        into m
                        from motifs in m.DefaultIfEmpty()
                        where consult.ID_Patient == idPatient
                        select new
                        {
                            consult.ID_Consultation,
                            consult.DateTime,
                            Motifs = motifs.Libelle,
                            Montant = paiment.Montant_Actuel,
                            Versement = paiment.Versement,
                            Reste = paiment.RestePayer
                        };
            gridControl_Consultation.DataSource = query.ToList();
            #region RepositoryItem
            RepositoryItemButtonEdit riButton = new RepositoryItemButtonEdit();
            riButton.TextEditStyle = TextEditStyles.HideTextEditor;
            riButton.Buttons[0].Kind = ButtonPredefines.Glyph;
            riButton.Buttons[0].Image = Properties.Resources.add_16px;
            riButton.Buttons.Add(new EditorButton(ButtonPredefines.Glyph));
            gridControl_Consultation.RepositoryItems.Add(riButton);
            gridView1.Columns.ColumnByFieldName(nameof(DAL.Consultations.ID_Consultation)).Caption = "Action";
            gridView1.Columns[nameof(DAL.Consultations.ID_Consultation)].ColumnEdit = riButton;
            //riButton.ButtonPressed += RiButton_ButtonClick;
            #endregion
        }

        public void DefultTextEdit(int id)
        {
            var consult = Master.db.Consultations.FirstOrDefault(a => a.ID_Consultation == id);
            if (consult == null)
                return;
            txt_Poids.Text = consult.Poids.ToString();
            txt_Taille.Text = consult.Taille.ToString();
            txt_Temperator.Text = consult.Temperature.ToString();
            txt_FCardiaque.Text = consult.FrequenceCardiaque.ToString();
            txt_Glycemie.Text = consult.Glycecmie.ToString();
            txt_PressionArterielle.Text = consult.PressionArterielle.ToString();
        }

        private void Btn_EditData_Click(object sender, EventArgs e)
        {
            if (!IsDataValide())
                return;
            Edit();
        }

        public void DefultTextEdit()
        {
            txt_Poids.Text = "0";
            txt_Taille.Text = "0";
            txt_Temperator.Text = "Ex 36";
            txt_FCardiaque.Text = "Ex 70";
            txt_Glycemie.Text = "Ex 1.4";
            txt_PressionArterielle.Text = "Ex 8/12";
        }

        public void ClearTextFromBox(TextEdit text) => text.Text = string.Empty;

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

        public void EditData(int idPatient)
        {
            GetData();
            if (idPatient == 0)
                return;
            patient = Master.db.Patient.First(a => a.ID_Patient == idPatient);
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
