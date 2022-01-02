namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ordonnances
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Consultation { get; set; }

        public int? ID_Medicament { get; set; }

        public int? ID_Quantite { get; set; }

        public int? ID_Posologie { get; set; }

        public string Note { get; set; }

        public DateTime? DateTime { get; set; }

        public int? ID_Vaccin { get; set; }

        public int? Qsp { get; set; }

        public virtual Consultations Consultations { get; set; }

        public virtual Medicament Medicament { get; set; }

        public virtual Posologies Posologies { get; set; }

        public virtual Quantites Quantites { get; set; }

        public virtual Vaccins Vaccins { get; set; }
    }
}
