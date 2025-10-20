namespace Nguoi2_BuocDau.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Ga")]
    public partial class Ga
    {
        public Ga()
        {
            LichTrinhs = new HashSet<LichTrinh>();
            LienKets = new HashSet<LienKet>();
            LienKets1 = new HashSet<LienKet>();
        }

        [Key]
        [StringLength(10)]
        public string MaGa { get; set; }

        [StringLength(100)]
        public string TenGa { get; set; }

        [StringLength(10)]
        public string MaTuyen { get; set; }

        public int? ThuTu { get; set; }

        public virtual Tuyen Tuyen { get; set; }

        public virtual ICollection<LichTrinh> LichTrinhs { get; set; }

        public virtual ICollection<LienKet> LienKets { get; set; }

        public virtual ICollection<LienKet> LienKets1 { get; set; }
    }
}
