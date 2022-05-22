using DevExpress.XtraEditors;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Consultation
{
    public partial class Nouveau_Motif : XtraForm
    {
        public Nouveau_Motif()
        {
            InitializeComponent();
        }

        private void Nouveau_Motif_Load(object sender, EventArgs e)
        {
            btn_Annuler.Click += Btn_Anunuler_Click;
            btn_Valid.Click += Btn_Valider_Click;
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            DAL.Motifs motif = new DAL.Motifs();
            if (txt_LibelleMotif.Text == string.Empty)
            {
                txt_LibelleMotif.ErrorText = Properties.Settings.Default.ErrorText;
                return;
            }
            if (Master.db.Motifs.Any(a => a.Libelle == txt_LibelleMotif.Text))
                XtraMessageBox.Show("Cette Libelle est déjà sur la liste des motifs ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                motif.Libelle = txt_LibelleMotif.Text;
                motif.Adreviation = txt_AdreviationMotif.Text;
                Master.db.Motifs.Add(motif);
                Master.db.SaveChanges();
                XtraMessageBox.Show("Saved Succesffuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void Btn_Anunuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
