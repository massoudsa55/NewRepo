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

namespace Gestion_Cabinet_Medical.Forms.Bilans
{
    public partial class Fiche_Bilan : XtraForm
    {
        public int _ID_Patient = 3;
        public int _ID_Consultation;
        DAL.Patient patient;
        public Fiche_Bilan()
        {
            InitializeComponent();
        }

        private void Fiche_Bilan_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now.Date;
            LoadTypeBilan();
            GetBilanSelected();
            GetBilanForPatientAdd();
            LoadConsultation(_ID_Patient);
            LoadPatientInfo(_ID_Patient);
        }

        private void LoadPatientInfo(int iD_Patient)
        {
            patient = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient);
            if (patient == null)
                return;
            label_NomPrenom.Text = patient.Nom + " " + patient.Prenom;
            layoutControlGroup_PatientInfo.Text = patient.Nom + " " + patient.Prenom;
            if (patient.Image != null)
                pic_ImagePatient.Image = Master.GetImageFromByteArray(patient.Image);
            label_NumbreConsultation.Text = Master.db.Consultations.Count(a => a.ID_Patient == _ID_Patient).ToString();
            if (Master.db.Attende.Any(a => a.ID_Patient == _ID_Patient))
                label_SalleAttente.Text = "Oui";
            else
                label_SalleAttente.Text = "Non";
        }

        public void LoadConsultation(int iD_Patient)
        {
            var query = from consult in Master.db.Consultations
                        join motifs in Master.db.Motifs on consult.ID_Motifs equals motifs.ID_Motifs
                        into m
                        from motifs in m.DefaultIfEmpty()
                        where consult.ID_Patient == iD_Patient
                        select new
                        {
                            consult.DateTime,
                            Motifs = motifs.Libelle,
                        };
            lkp_Consultation.Properties.DataSource = query.ToList();
        }

        public void GetBilanForPatientAdd()
        {
        }

        public void GetBilanSelected()
        {
        }

        public void LoadTypeBilan()
        {
            var query = from typeBilan in Master.db.BilansCategories
                        select new
                        {
                            typeBilan.ID_Cat_Bilans,
                            typeBilan.Libelle,
                            typeBilan.Raccourcis
                        };
            lkp_TypeBilan.Properties.DataSource = query.ToList();
        }
    }
}
