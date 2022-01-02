namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Radiologie")]
    public partial class Radiologie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Radiologie()
        {
            Test = new HashSet<Test>();
        }

        [Key]
        public int ID_Radiologie { get; set; }

        [Required]
        public string Examen { get; set; }

        public string Remarque { get; set; }

        public double? Mnt_Par_Defaut { get; set; }

        public double? Montant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test> Test { get; set; }
    }
}
