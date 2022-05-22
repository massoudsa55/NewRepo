namespace Gestion_Cabinet_Medical.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BilansCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BilansCategories()
        {
            Bilans = new HashSet<Bilans>();
        }

        [Key]
        public int ID_Cat_Bilans { get; set; }

        public string Libelle { get; set; }

        public string Raccourcis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilans> Bilans { get; set; }
    }
}
