namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RanduFaut")]
    public partial class RanduFaut
    {
        [Key]
        public int ID_RF { get; set; }

        public int ID_Consultation { get; set; }

        public string TitreRF { get; set; }

        public int? ID_TypeRF { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateRF { get; set; }

        public string Description { get; set; }

        public TimeSpan? HeurDebut { get; set; }

        public TimeSpan? HeurFin { get; set; }

        public virtual Consultations Consultations { get; set; }

        public virtual TypeRanduFaut TypeRanduFaut { get; set; }
    }
}
