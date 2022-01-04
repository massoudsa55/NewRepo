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
using Gestion_Cabinet_Medical.Functions;

namespace Gestion_Cabinet_Medical.Forms.Patient
{
    public partial class Nouveau_Patient : DevExpress.XtraEditors.XtraForm
    {
        string Day = "01";
        string Month = "01";
        int _ID_Daira;
        int _ID_Sexe;
        int _ID_Civilite;
        int _ID_GroupeSanguin;
        int _ID_SituationFam;
        public string EditOrAdd;
        public int _ID_Patient;
        DAL.Patient patient;
        public Nouveau_Patient()
        {
            InitializeComponent();
        }

        private void Nouveau_Patient_Load(object sender, EventArgs e)
        {
            switch (EditOrAdd)
            {
                case "Add":
                    GetData();
                    break;
                case "Edit":
                    EditData(_ID_Patient);
                    break;
                default:
                    break;
            }
            #region Events
            linkLabel_ChampOPL.MouseDown += LinkLabel_ChampOPL_MouseDown;
            linkLabel_ChampOPL.MouseUp += LinkLabel_ChampOPL_MouseUp;
            btnFermer.Click += BtnFermer_Click;
            btnOK.Click += BtnOK_Click;
            slkp_Wilaya.EditValueChanged += Slkp_Wilaya_EditValueChanged;
            txt_Age.EditValueChanged += Txt_Age_EditValueChanged;
            dateEdit_DOB.EditValueChanged += DateEdit_DOB_EditValueChanged;
            checkEdit_Presume.CheckedChanged += Txt_Age_EditValueChanged;
            dateEdit_DOB.TabIndexChanged += DateEdit_DOB_EditValueChanged;
            txt_Code.KeyDown += Propertices_KeyDown;
            txt_Nom.KeyDown += Propertices_KeyDown;
            txt_Prenom.KeyDown += Propertices_KeyDown;
            txt_FileDe.KeyDown += Propertices_KeyDown;
            dateEdit_DOB.KeyDown += Propertices_KeyDown;
            txt_Age.KeyDown += Propertices_KeyDown;
            checkEdit_Presume.KeyDown += Propertices_KeyDown;
            lkp_Sexe.KeyDown += Propertices_KeyDown;
            lkp_Civilite.KeyDown += Propertices_KeyDown;
            txt_Address.KeyDown += Propertices_KeyDown;
            slkp_Wilaya.KeyDown += Propertices_KeyDown;
            slkp_Daira.KeyDown += Propertices_KeyDown;
            txt_Phon1.KeyDown += Propertices_KeyDown;
            txt_Phon2.KeyDown += Propertices_KeyDown;
            txt_Email.KeyDown += Propertices_KeyDown;
            lkp_GroupSanguin.KeyDown += Propertices_KeyDown;
            lkp_SituationFam.KeyDown += Propertices_KeyDown;
            txt_Prefession.KeyDown += Propertices_KeyDown;
            txt_Note.KeyDown += Propertices_KeyDown;
            btnOK.KeyDown += Propertices_KeyDown;
            btnFermer.KeyDown += Propertices_KeyDown;
            #endregion
        }

        private void Propertices_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F1:
                    BtnOK_Click(null, null);
                    break;
                default:
                    {
                        if (sender is DevExpress.XtraEditors.TextEdit sendTXT)
                        {
                            switch (sendTXT.Name)
                            {
                                case "txt_Code":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Down:
                                            txt_Nom.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_Nom.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_Nom":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_Code.Focus();
                                            break;
                                        case Keys.Down:
                                            txt_Prenom.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_Prenom.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_Prenom":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_Nom.Focus();
                                            break;
                                        case Keys.Down:
                                            txt_FileDe.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_FileDe.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_FileDe":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_Prenom.Focus();
                                            break;
                                        case Keys.Down:
                                            dateEdit_DOB.Focus();
                                            break;
                                        case Keys.Enter:
                                            dateEdit_DOB.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_Address":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            lkp_Civilite.Focus();
                                            break;
                                        case Keys.Down:
                                            slkp_Wilaya.Focus();
                                            break;
                                        case Keys.Enter:
                                            slkp_Wilaya.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_Phon1":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            slkp_Daira.Focus();
                                            break;
                                        case Keys.Right:
                                            txt_Phon2.Focus();
                                            break;
                                        case Keys.Down:
                                            txt_Email.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_Phon2.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_Phon2":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Left:
                                            txt_Phon1.Focus();
                                            break;
                                        case Keys.Down:
                                            txt_Email.Focus();
                                            break;
                                        case Keys.Up:
                                            slkp_Daira.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_Email.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_Email":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_Phon2.Focus();
                                            break;
                                        case Keys.Down:
                                            lkp_GroupSanguin.Focus();
                                            break;
                                        case Keys.Enter:
                                            lkp_GroupSanguin.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_Prefession":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            lkp_GroupSanguin.Focus();
                                            break;
                                        case Keys.Left:
                                            lkp_SituationFam.Focus();
                                            break;
                                        case Keys.Down:
                                            txt_Note.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_Note.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "txt_Age":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_FileDe.Focus();
                                            break;
                                        case Keys.Right:
                                            checkEdit_Presume.Focus();
                                            break;
                                        case Keys.Left:
                                            dateEdit_DOB.Focus();
                                            break;
                                        case Keys.Enter:
                                            lkp_Sexe.Focus();
                                            break;
                                        case Keys.Down:
                                            lkp_Sexe.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (sender is DevExpress.XtraEditors.DateEdit)
                        {
                            switch (e.KeyCode)
                            {
                                case Keys.Up:
                                    txt_FileDe.Focus();
                                    break;
                                case Keys.Down:
                                    lkp_Sexe.Focus();
                                    break;
                                case Keys.Enter:
                                    lkp_Sexe.Focus();
                                    break;
                                case Keys.Tab:
                                    lkp_Sexe.Focus();
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (sender is DevExpress.XtraEditors.LookUpEdit sendLKP)
                        {
                            switch (sendLKP.Name)
                            {
                                case "lkp_Sexe":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Enter:
                                            lkp_Civilite.Focus();
                                            break;
                                        case Keys.Left:
                                            lkp_Civilite.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "lkp_Civilite":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Right:
                                            lkp_Sexe.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_Address.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "lkp_GroupSanguin":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_Address.Focus();
                                            break;
                                        case Keys.Down:
                                            txt_Prefession.Focus();
                                            break;
                                        case Keys.Enter:
                                            lkp_SituationFam.Focus();
                                            break;
                                        case Keys.Left:
                                            lkp_SituationFam.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "lkp_SituationFam":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_Address.Focus();
                                            break;
                                        case Keys.Right:
                                            lkp_GroupSanguin.Focus();
                                            break;
                                        case Keys.Down:
                                            txt_Prefession.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_Prefession.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (sender is DevExpress.XtraEditors.SearchLookUpEdit sendSLPK)
                        {
                            switch (sendSLPK.Name)
                            {
                                case "slkp_Wilaya":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Enter:
                                            slkp_Daira.Focus();
                                            break;
                                        case Keys.Right:
                                            slkp_Daira.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "slkp_Daira":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Left:
                                            slkp_Wilaya.Focus();
                                            break;
                                        case Keys.Enter:
                                            txt_Phon1.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (sender is TextBox)
                        {
                            switch (e.KeyCode)
                            {
                                case Keys.Tab:
                                    btnOK.Focus();
                                    break;
                                case Keys.Enter:
                                    BtnOK_Click(null, null);
                                    break;
                                case Keys.Up:
                                    txt_Prefession.Focus();
                                    break;
                                case Keys.Down:
                                    btnOK.Focus();
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (sender is DevExpress.XtraEditors.CheckEdit)
                        {
                            switch (e.KeyCode)
                            {
                                case Keys.Up:
                                    txt_FileDe.Focus();
                                    break;
                                case Keys.Down:
                                    lkp_Sexe.Focus();
                                    break;
                                case Keys.Enter:
                                    lkp_Sexe.Focus();
                                    break;
                                case Keys.Tab:
                                    lkp_Sexe.Focus();
                                    break;
                                case Keys.Left:
                                    txt_Age.Focus();
                                    break;
                                case Keys.Right:
                                    imageEdit_Image.Focus();
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (sender is DevExpress.XtraEditors.SimpleButton sendBTN)
                        {
                            switch (sendBTN.Name)
                            {
                                case "btnOK":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_Prefession.Focus();
                                            break;
                                        case Keys.Enter:
                                            Save();
                                            break;
                                        case Keys.Tab:
                                            btnFermer.Focus();
                                            break;
                                        case Keys.Right:
                                            btnFermer.Focus();
                                            break;
                                        case Keys.Left:
                                            txt_Prefession.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "btnFermer":
                                    switch (e.KeyCode)
                                    {
                                        case Keys.Up:
                                            txt_Prefession.Focus();
                                            break;
                                        case Keys.Enter:
                                            btnFermer.PerformClick();
                                            break;
                                        case Keys.Tab:
                                            linkLabel_ChampOPL.Focus();
                                            break;
                                        case Keys.Left:
                                            btnFermer.Focus();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!IsDataValide())
                return;
            else
            {
                switch (EditOrAdd)
                {
                    case "Add":
                        Save();
                        Close();
                        break;
                    case "Edit":
                        Edit();
                        Close();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Txt_Age_EditValueChanged(object sender, EventArgs e)
        {
            string DOB;
            if (txt_Age.Text == string.Empty)
                return;
            else
            {
                string yearDOB = (DateTime.Now.Year - Convert.ToInt32(txt_Age.Text)).ToString();
                if (checkEdit_Presume.Checked)
                    DOB = Day + "-" + Month + "-" + yearDOB;
                else
                    DOB = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + yearDOB;
                dateEdit_DOB.Text = DOB;
            }
        }

        private void DateEdit_DOB_EditValueChanged(object sender, EventArgs e)
        {
            string age = ((int)DateTime.Now.Year - (int?)dateEdit_DOB.DateTime.Year ?? 0).ToString();
            txt_Age.Text = age;
        }

        public void ChoseWilaya()
        {
            if (slkp_Wilaya.EditValue != null && slkp_Wilaya.Text != string.Empty)
            {
                var id_Wilaya = (int?)Master.db.Wilaya.First(a => a.NameWilaya == slkp_Wilaya.Text).ID_Wilaya ?? 0;
                if (id_Wilaya > 0)
                {
                    var lesDaira = Master.db.Daira.Where(a => a.ID_Wilaya == id_Wilaya).Select(b => b.NameDaira).ToList();
                    if (lesDaira != null)
                        slkp_Daira.Properties.DataSource = lesDaira;
                }
            }
        }

        private void Slkp_Wilaya_EditValueChanged(object sender, EventArgs e)
        {
            ChoseWilaya();
        }

        public string GetFirsname(int id)
        {
            if (id != 0)
            {
                var firstName = Master.db.Patient.First(a => a.ID_Patient == id).Prenom;
                if (firstName != string.Empty)
                    return firstName;
            }
            return "";
        }

        public void GetData()
        {
            txt_Code.Text = Master.GetNewCode();
            var sexe = Master.db.Sexe.Select(e => e.Type).ToList();
            var civilite = Master.db.Civilite.Select(e => e.Type).ToList();
            var groupeSanguin = Master.db.GroupeSanguin.Select(e => e.Type).ToList();
            var situationFam = Master.db.SituationFam.Select(e => e.Type).ToList();
            var wilaya = Master.db.Wilaya.Select(e => e.NameWilaya).ToList();
            lkp_Sexe.EditValue = sexe[0];
            lkp_Sexe.Properties.DataSource = sexe;
            lkp_Civilite.EditValue = civilite[0];
            lkp_Civilite.Properties.DataSource = civilite;
            lkp_GroupSanguin.EditValue = groupeSanguin[0];
            lkp_GroupSanguin.Properties.DataSource = groupeSanguin;
            lkp_SituationFam.EditValue = situationFam[0];
            lkp_SituationFam.Properties.DataSource = situationFam;
            slkp_Wilaya.Properties.DataSource = wilaya;
        }

        public void ClearBoxes()
        {
            txt_Code.Text = string.Empty;
            txt_Nom.Text = string.Empty;
            txt_Prenom.Text = string.Empty;
            txt_FileDe.Text = string.Empty;
            dateEdit_DOB.EditValue = null;
            txt_Age.Text = string.Empty;
            slkp_Daira.EditValue = null;
            slkp_Wilaya.EditValue = null;
            lkp_Civilite.EditValue = null;
            txt_Address.Text = string.Empty;
            txt_Phon1.Text = string.Empty;
            txt_Phon2.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Prefession.Text = string.Empty;
            txt_Note.Text = string.Empty;
            GetData();
        }

        public void SetData()
        {
            GetIdDaira();
            GetIdSexe();
            GetIdCivilite();
            GetIdGroupeSanguin();
            GetIdSituationFam();
            if (EditOrAdd == "Add")
                patient = new DAL.Patient();
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
            if (imageEdit_Image.Image != null)
                patient.Image = Master.GetByteFromImage(imageEdit_Image.Image);
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
                ChoseWilaya();
                slkp_Daira.Text = Master.GetDaira(Convert.ToInt32(patient.ID_Daira));
            }
            txt_Phon1.Text = patient.Phone1;
            txt_Phon2.Text = patient.Phone2;
            txt_Email.Text = patient.Email;
            lkp_GroupSanguin.Text = Master.GetGroupeSanguin(Convert.ToInt32(patient.ID_GroupeSanguin));
            lkp_SituationFam.Text = Master.GetSituationFam(Convert.ToInt32(patient.ID_SF));
            txt_Prefession.Text = patient.Profession;
            txt_Note.Text = patient.Note;
            imageEdit_Image.Image = Master.GetImageFromByteArray(patient.Image);
        }

        public void Save()
        {
            SetData();
            Master.db.Patient.Add(patient);
            Master.db.SaveChanges();
            MessageBox.Show("Saved Succesffuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearBoxes();
        }

        public void Edit()
        {
            SetData();
            Master.db.Entry(patient).State = EntityState.Modified;
            Master.db.SaveChanges();
            MessageBox.Show("Edited Succesffuly", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearBoxes();
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

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LinkLabel_ChampOPL_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Code.BackColor = Color.FromArgb(219, 220, 225);
            txt_Nom.BackColor = Color.White;
            txt_Prenom.BackColor = Color.White;
            txt_Phon1.BackColor = Color.White;
            dateEdit_DOB.BackColor = Color.White;
        }

        private void LinkLabel_ChampOPL_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Code.BackColor = Color.FromArgb(255, 128, 128);
            txt_Nom.BackColor = Color.FromArgb(255, 128, 128);
            txt_Prenom.BackColor = Color.FromArgb(255, 128, 128);
            txt_Phon1.BackColor = Color.FromArgb(255, 128, 128);
            dateEdit_DOB.BackColor = Color.FromArgb(255, 128, 128);
        }
    }
}
