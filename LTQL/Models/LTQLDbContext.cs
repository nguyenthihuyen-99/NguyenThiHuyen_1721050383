using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<Muon> Muons { get; set; }
        public virtual DbSet<Tacgia> Tacgias { get; set; }
        public virtual DbSet<Docgia> Docgias { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet<Theloai> Theloais { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);
            modelBuilder.Entity<Sach>()
                .Property(e => e.Masach);
            modelBuilder.Entity<Muon>()
               .Property(e => e.Mamuon);
            modelBuilder.Entity<Tacgia>()
               .Property(e => e.Matacgia);
            modelBuilder.Entity<Docgia>()
               .Property(e => e.Madocgia);
            modelBuilder.Entity<NhaXuatBan>()
               .Property(e => e.MaNXB);
            modelBuilder.Entity<Nhanvien>()
               .Property(e => e.MaNV);



        }

    }
}
