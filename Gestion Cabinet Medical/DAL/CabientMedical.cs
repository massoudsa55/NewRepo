namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CabientMedical")]
    public partial class CabientMedical
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CabientMedical()
        {
            Paiement = new HashSet<Paiement>();
        }

        [Key]
        public int ID_CM { get; set; }

        [Required]
        public string NameFR { get; set; }

        public string NameAR { get; set; }

        [Required]
        public string SpecialiteFR { get; set; }

        public string SpecialiteAR { get; set; }

        [Required]
        public string AddressFR { get; set; }

        public string AddressAR { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Telephone { get; set; }

        public string AutreInfoFR { get; set; }

        public string AutreInfoAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paiement> Paiement { get; set; }
    }
}
