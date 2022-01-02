namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            Paiement = new HashSet<Paiement>();
        }

        [Key]
        public int ID_User { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        public int? ID_TypeUser { get; set; }

        public double? Salary { get; set; }

        public DateTime DateCreation { get; set; }

        public string Email { get; set; }

        public string Adresse { get; set; }

        [Required]
        public string Phone { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paiement> Paiement { get; set; }

        public virtual TypeUser TypeUser { get; set; }
    }
}
