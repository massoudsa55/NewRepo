namespace Gestion_Cabinet_Medical.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Motifs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Motifs()
        {
            Consultations = new HashSet<Consultations>();
        }

        [Key]
        public int ID_Motifs { get; set; }

        [Required]
        public string Libelle { get; set; }

        public string Adreviation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultations> Consultations { get; set; }
    }
}
