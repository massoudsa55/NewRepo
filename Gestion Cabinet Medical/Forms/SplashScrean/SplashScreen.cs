using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.SplashScrean
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            LoadData();
        }

        void TextChange(string text)
        {
            txtDownloadData.Text = "Nous téléchargans vos données " + text;
        }

        public async void LoadData()
        {
            TextChange("Analyses");
            await Functions.Master.db.Analyse.LoadAsync();
            TextChange("Antecedents");
            await Functions.Master.db.Antecedents.LoadAsync();
            TextChange("Attendes");
            await Functions.Master.db.Attende.LoadAsync();
            TextChange("Bilans");
            await Functions.Master.db.Bilans.LoadAsync();
            TextChange("BilansCategories");
            await Functions.Master.db.BilansCategories.LoadAsync();
            TextChange("CabientMedicals");
            await Functions.Master.db.CabientMedical.LoadAsync();
            TextChange("Civilites");
            await Functions.Master.db.Civilite.LoadAsync();
            TextChange("Consultations");
            await Functions.Master.db.Consultations.LoadAsync();
            TextChange("Dairas");
            await Functions.Master.db.Daira.LoadAsync();
            TextChange("EtatMaladies");
            await Functions.Master.db.EtatMaladie.LoadAsync();
            TextChange("FamAnalyses");
            await Functions.Master.db.FamAnalyse.LoadAsync();
            TextChange("GroupeSanguins");
            await Functions.Master.db.GroupeSanguin.LoadAsync();
            TextChange("Medicaments");
            await Functions.Master.db.Medicament.LoadAsync();
            TextChange("ModePaiements");
            await Functions.Master.db.ModePaiement.LoadAsync();
            TextChange("Motifs");
            await Functions.Master.db.Motifs.LoadAsync();
            TextChange("Ordonnances");
            await Functions.Master.db.Ordonnances.LoadAsync();
            TextChange("Paiements");
            await Functions.Master.db.Paiement.LoadAsync();
            TextChange("Patients");
            await Functions.Master.db.Patient.LoadAsync();
            TextChange("Pays");
            await Functions.Master.db.Pays.LoadAsync();
            TextChange("Permissions");
            await Functions.Master.db.Permissions.LoadAsync();
            TextChange("Posologies");
            await Functions.Master.db.Posologies.LoadAsync();
            TextChange("Quantites");
            await Functions.Master.db.Quantites.LoadAsync();
            TextChange("Radiographies");
            await Functions.Master.db.Radiographie.LoadAsync();
            TextChange("Radiologies");
            await Functions.Master.db.Radiologie.LoadAsync();
            TextChange("RanduFauts");
            await Functions.Master.db.RanduFaut.LoadAsync();
            TextChange("SituationFams");
            await Functions.Master.db.SituationFam.LoadAsync();
            TextChange("Sexes");
            await Functions.Master.db.Sexe.LoadAsync();
            TextChange("StatusAttendes");
            await Functions.Master.db.StatusAttende.LoadAsync();
            TextChange("Tests");
            await Functions.Master.db.Test.LoadAsync();
            TextChange("TypePaiements");
            await Functions.Master.db.TypePaiement.LoadAsync();
            TextChange("TypeRanduFauts");
            await Functions.Master.db.TypeRanduFaut.LoadAsync();
            TextChange("TypeUsers");
            await Functions.Master.db.TypeUser.LoadAsync();
            TextChange("Users");
            await Functions.Master.db.Users.LoadAsync();
            TextChange("Vaccins");
            await Functions.Master.db.Vaccins.LoadAsync();
            TextChange("Wilayas");
            await Functions.Master.db.Wilaya.LoadAsync();
            Hide();
            if (Functions.Master.db.Users.Count() == 0)
            {
                User.Add_User add = new User.Add_User();
                add.Show();
            }
            else
            {
                Login.Login_Form login = new Login.Login_Form();
                login.Show();
            }
        }
    }
}
