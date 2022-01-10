using DevExpress.XtraEditors;
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

namespace Gestion_Cabinet_Medical.Forms.Consultation
{
    public partial class Consultation_Management : XtraForm
    {
        int _ID_Daira;
        int _ID_Sexe;
        int _ID_Civilite;
        int _ID_GroupeSanguin;
        int _ID_SituationFam;
        public int _ID_Patient=1;
        DAL.Patient patient;
        public Consultation_Management()
        {
            InitializeComponent();
        }

        private void Consultation_Management_Load(object sender, EventArgs e)
        {
            EditData(_ID_Patient);
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
            }
            txt_Phon1.Text = patient.Phone1;
            txt_Phon2.Text = patient.Phone2;
            txt_Email.Text = patient.Email;
            lkp_GroupSanguin.Text = Master.GetGroupeSanguin(Convert.ToInt32(patient.ID_GroupeSanguin));
            lkp_SituationFam.Text = Master.GetSituationFam(Convert.ToInt32(patient.ID_SF));
            txt_Prefession.Text = patient.Profession;
            txt_Note.Text = patient.Note;
        }
    }
}
