namespace Gestion_Cabinet_Medical.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Daira")]
    public partial class Daira
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Daira()
        {
            Patient = new HashSet<Patient>();
        }

        [Key]
        public int ID_Daira { get; set; }

        public int Code { get; set; }

        [Required]
        public string NameDaira { get; set; }

        public int ID_Wilaya { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patient { get; set; }

        public virtual Wilaya Wilaya { get; set; }
    }
}
