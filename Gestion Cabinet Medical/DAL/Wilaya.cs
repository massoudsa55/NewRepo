namespace Gestion_Cabinet_Medical.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Wilaya")]
    public partial class Wilaya
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wilaya()
        {
            Daira = new HashSet<Daira>();
        }

        [Key]
        public int ID_Wilaya { get; set; }

        public int Code { get; set; }

        [Required]
        public string NameWilaya { get; set; }

        public int ID_Pays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Daira> Daira { get; set; }

        public virtual Pays Pays { get; set; }
    }
}
