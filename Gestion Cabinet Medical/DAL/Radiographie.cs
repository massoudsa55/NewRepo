namespace Gestion_Cabinet_Medical.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Radiographie")]
    public partial class Radiographie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Radiographie()
        {
            Test = new HashSet<Test>();
        }

        [Key]
        public int ID_Radiographie { get; set; }

        [Required]
        public string Examen { get; set; }

        public string Remarque { get; set; }

        public double? Mnt_Par_Defaut { get; set; }

        public double? Montant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test> Test { get; set; }
    }
}
