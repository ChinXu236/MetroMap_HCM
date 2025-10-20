using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Nguoi2_BuocDau.model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Ga> Gas { get; set; }
        public virtual DbSet<LichTrinh> LichTrinhs { get; set; }
        public virtual DbSet<LienKet> LienKets { get; set; }
        public virtual DbSet<Tuyen> Tuyens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ga>()
                .HasMany(e => e.LichTrinhs)
                .WithRequired(e => e.Ga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ga>()
                .HasMany(e => e.LienKets)
                .WithOptional(e => e.Ga)
                .HasForeignKey(e => e.MaGa1);

            modelBuilder.Entity<Ga>()
                .HasMany(e => e.LienKets1)
                .WithOptional(e => e.Ga1)
                .HasForeignKey(e => e.MaGa2);

            modelBuilder.Entity<Tuyen>()
                .HasMany(e => e.LichTrinhs)
                .WithRequired(e => e.Tuyen)
                .WillCascadeOnDelete(false);
        }
    }
}
