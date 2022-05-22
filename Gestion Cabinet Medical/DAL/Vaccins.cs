namespace Gestion_Cabinet_Medical.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Vaccins
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vaccins()
        {
            Ordonnances = new HashSet<Ordonnances>();
        }

        [Key]
        public int ID_Vaccin { get; set; }

        public string Code { get; set; }

        public string Libelle { get; set; }

        public string Age { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordonnances> Ordonnances { get; set; }
    }
}
