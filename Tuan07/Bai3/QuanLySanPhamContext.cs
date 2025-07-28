using Bai3;
using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Bai3
{
    public class QuanLySanPhamContext : DbContext
    {
        public QuanLySanPhamContext()
            : base("name=QuanLySanPhamContext")
        { }

        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
    }
}
