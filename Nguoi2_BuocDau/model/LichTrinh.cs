namespace Nguoi2_BuocDau.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichTrinh")]
    public partial class LichTrinh
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTuyen { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGa { get; set; }

        public TimeSpan GioXuatPhat { get; set; }

        public int ThoiGianDenTiepTheo { get; set; }

        public virtual Ga Ga { get; set; }

        public virtual Tuyen Tuyen { get; set; }
    }
}
