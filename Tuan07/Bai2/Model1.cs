using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bai2
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QuanLySinhVien")
        {
        }

        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
