namespace Gestion_Cabinet_Medical.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Quantites
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quantites()
        {
            Ordonnances = new HashSet<Ordonnances>();
        }

        [Key]
        public int ID_Quantite { get; set; }

        [Required]
        public string Libelle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordonnances> Ordonnances { get; set; }
    }
}
