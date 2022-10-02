using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace learn.net.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=AppDBContext")
        {
        }

        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.SinhViens)
                .WithOptional(e => e.LopHoc)
                .HasForeignKey(e => e.IDLopHoc);
        }
    }
}
