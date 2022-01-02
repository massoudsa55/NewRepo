namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Consultations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Consultations()
        {
            Paiement = new HashSet<Paiement>();
            RanduFaut = new HashSet<RanduFaut>();
            Test = new HashSet<Test>();
        }

        [Key]
        public int ID_Consultation { get; set; }

        public int ID_Patient { get; set; }

        public DateTime DateTime { get; set; }

        public int? ID_Motifs { get; set; }

        public int? Poids { get; set; }

        public int? Taille { get; set; }

        public int? Temperature { get; set; }

        public int? FrequenceCardiaque { get; set; }

        public double? Glycecmie { get; set; }

        public double? PressionArterielle { get; set; }

        public string Note { get; set; }

        public int? ID_Antecedent { get; set; }

        public virtual Antecedents Antecedents { get; set; }

        public virtual Motifs Motifs { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Ordonnances Ordonnances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paiement> Paiement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RanduFaut> RanduFaut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test> Test { get; set; }
    }
}
