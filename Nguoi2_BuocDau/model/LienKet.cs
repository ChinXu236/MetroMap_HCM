namespace Nguoi2_BuocDau.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienKet")]
    public partial class LienKet
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaGa1 { get; set; }

        [StringLength(10)]
        public string MaGa2 { get; set; }

        public double? KhoangCach { get; set; }

        public virtual Ga Ga { get; set; }

        public virtual Ga Ga1 { get; set; }
    }
}
