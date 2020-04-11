using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace covid19.Models
{
    public partial class covidBDContext : DbContext
    {
        public covidBDContext()
        {
        }

        public covidBDContext(DbContextOptions<covidBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Casos> Casos { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{

            //   // optionsBuilder.UseMySql("server=142.93.56.210;port=3306;database=covidBD;uid=peyu;password=Valinor00*", x => x.ServerVersion("5.7.29-mysql"));
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Casos>(entity =>
            //{
            //    entity.ToTable("casos");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .HasColumnType("int(2)");

            //    entity.Property(e => e.Activos)
            //        .HasColumnName("activos")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.Muertes)
            //        .HasColumnName("muertes")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.Provincia_Id)
            //        .HasColumnName("provincia_id")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.Recuperados)
            //        .HasColumnName("recuperados")
            //        .HasColumnType("int(11)");
            //});

            //modelBuilder.Entity<Provincias>(entity =>
            //{
            //    entity.ToTable("provincias");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .HasColumnType("int(2)");

            //    entity.Property(e => e.Provincia)
            //        .IsRequired()
            //        .HasColumnName("provincia")
            //        .HasColumnType("varchar(45)")
            //        .HasCharSet("latin1")
            //        .HasCollation("latin1_swedish_ci");

            //    entity.Property(e => e.Respiradores)
            //        .HasColumnName("respiradores")
            //        .HasColumnType("int(11)");
            //});

            //OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
