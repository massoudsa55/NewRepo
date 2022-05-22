namespace Gestion_Cabinet_Medical.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Permissions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permissions()
        {
            TypeUser = new HashSet<TypeUser>();
        }

        [Key]
        public int ID_Permission { get; set; }

        [Required]
        public string Type_Permission { get; set; }

        public bool Activty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeUser> TypeUser { get; set; }
    }
}
