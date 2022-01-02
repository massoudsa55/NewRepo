namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Attende = new HashSet<Attende>();
            Consultations = new HashSet<Consultations>();
        }

        [Key]
        public int ID_Patient { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        public string FileDe { get; set; }

        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public int? ID_Sexe { get; set; }

        public int? ID_Civilite { get; set; }

        public int? ID_GroupeSanguin { get; set; }

        public int? ID_SF { get; set; }

        [Required]
        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Email { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public string Address { get; set; }

        public int? ID_Daira { get; set; }

        public string Profession { get; set; }

        public string Note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attende> Attende { get; set; }

        public virtual Civilite Civilite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultations> Consultations { get; set; }

        public virtual Daira Daira { get; set; }

        public virtual GroupeSanguin GroupeSanguin { get; set; }

        public virtual Sexe Sexe { get; set; }

        public virtual SituationFam SituationFam { get; set; }
    }
}
