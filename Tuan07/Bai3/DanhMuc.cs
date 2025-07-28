using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;





namespace Bai3
{
    [Table("DanhMuc")]
    public class DanhMuc
    {
        [Key]
        public int MaDanhMuc { get; set; }

        [Required, StringLength(100)]
        public string TenDanhMuc { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
