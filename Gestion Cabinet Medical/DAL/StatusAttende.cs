namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusAttende")]
    public partial class StatusAttende
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatusAttende()
        {
            Attende = new HashSet<Attende>();
        }

        [Key]
        public int ID_SA { get; set; }

        [Required]
        public string Type_SA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attende> Attende { get; set; }
    }
}
