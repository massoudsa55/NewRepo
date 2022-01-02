namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medicament")]
    public partial class Medicament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicament()
        {
            Ordonnances = new HashSet<Ordonnances>();
        }

        [Key]
        public int ID_Medicament { get; set; }

        public string Code { get; set; }

        public string Libelle { get; set; }

        public string DCI { get; set; }

        public string Dossage { get; set; }

        public string Condit { get; set; }

        public string Form { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordonnances> Ordonnances { get; set; }
    }
}
