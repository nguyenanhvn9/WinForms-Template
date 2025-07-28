using System.Data.Entity;

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;


namespace Bai3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        [Required]
        [StringLength(150)]
        public string TenSP { get; set; }

        public decimal DonGia { get; set; }

        public int SoLuongTon { get; set; }

        public int? MaDanhMuc { get; set; }
    }
}
