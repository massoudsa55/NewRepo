namespace Gestion_Cabinet_Medical.DAL
{
    using System.ComponentModel.DataAnnotations;

    public partial class Bilans
    {
        [Key]
        public int ID_Bilans { get; set; }

        public int ID_Cat_Bilans { get; set; }

        public int ID_Analyse { get; set; }

        public virtual Analyse Analyse { get; set; }

        public virtual BilansCategories BilansCategories { get; set; }
    }
}
