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
    public partial class Nouvelle_Consultation : XtraForm
    {
        public int _ID_Patient;
        DAL.Patient patient;
        public Nouvelle_Consultation()
        {
            InitializeComponent();
        }

        private void Nouvelle_Consultation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var query = from motif in Master.db.Motifs
                        select new
                        {
                            ID = motif.ID_Motifs,
                            motif.Libelle,
                            motif.Adreviation
                        };
            patient = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient);
            if (patient == null)
                return;
            dateEdit1.DateTime = DateTime.Now.Date;
            lookUpEdit1.Properties.DataSource = query.ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = nameof(DAL.Motifs.Libelle);
            label_NomPrenom.Text = patient.Nom + " " + patient.Prenom;
            if (patient.Image != null)
                pic_ImagePatient.Image = Master.GetImageFromByteArray(patient.Image);
            label_NumbreConsultation.Text = Master.db.Consultations.Count(a => a.ID_Patient == _ID_Patient).ToString();
            if (Master.db.Attende.Any(a => a.ID_Patient == _ID_Patient))
                label_SalleAttente.Text = "Oui";
            else
                label_SalleAttente.Text = "Non";
        }
    }
}
