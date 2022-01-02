namespace Gestion_Cabinet_Medical.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attende")]
    public partial class Attende
    {
        [Key]
        public int ID_Attende { get; set; }

        public int ID_Patient { get; set; }

        public int? ID_EM { get; set; }

        public int? ID_SA { get; set; }

        public virtual EtatMaladie EtatMaladie { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual StatusAttende StatusAttende { get; set; }
    }
}
