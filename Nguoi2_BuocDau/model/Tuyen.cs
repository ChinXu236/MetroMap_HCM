namespace Nguoi2_BuocDau.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tuyen")]
    public partial class Tuyen
    {
        public Tuyen()
        {
            Gas = new HashSet<Ga>();
            LichTrinhs = new HashSet<LichTrinh>();
        }

        [Key]
        [StringLength(10)]
        public string MaTuyen { get; set; }

        [StringLength(100)]
        public string TenTuyen { get; set; }

        [StringLength(200)]
        public string MoTa { get; set; }

        public virtual ICollection<Ga> Gas { get; set; }

        public virtual ICollection<LichTrinh> LichTrinhs { get; set; }
    }
}
