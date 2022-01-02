namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test")]
    public partial class Test
    {
        [Key]
        public int ID_Test { get; set; }

        public int ID_Consultation { get; set; }

        public bool IsAnalyse { get; set; }

        public int? ID_Analyse { get; set; }

        public bool IsRadiographie { get; set; }

        public int? ID_Radiographie { get; set; }

        public bool IsRadiologie { get; set; }

        public int? ID_Radiologie { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public string ResultatTest { get; set; }

        public string ResultatTotal { get; set; }

        public virtual Analyse Analyse { get; set; }

        public virtual Consultations Consultations { get; set; }

        public virtual Radiographie Radiographie { get; set; }

        public virtual Radiologie Radiologie { get; set; }
    }
}
