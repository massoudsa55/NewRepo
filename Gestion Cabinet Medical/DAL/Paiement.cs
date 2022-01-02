namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paiement")]
    public partial class Paiement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Paiment { get; set; }

        public int ID_User { get; set; }

        public double? Montant_Iniale { get; set; }

        public double Montant_Actuel { get; set; }

        public double? Versement { get; set; }

        public double? RestePayer { get; set; }

        public int ID_TypePaiement { get; set; }

        public int ID_ModePaiement { get; set; }

        public DateTime DateTime { get; set; }

        public string Note { get; set; }

        public int? ID_Consultation { get; set; }

        public int? ID_CM { get; set; }

        public virtual CabientMedical CabientMedical { get; set; }

        public virtual Consultations Consultations { get; set; }

        public virtual ModePaiement ModePaiement { get; set; }

        public virtual TypePaiement TypePaiement { get; set; }

        public virtual Users Users { get; set; }
    }
}
