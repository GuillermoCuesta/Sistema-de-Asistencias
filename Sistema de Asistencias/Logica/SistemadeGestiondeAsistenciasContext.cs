using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public partial class SistemadeGestiondeAsistenciasContext : DbContext
    {
        public SistemadeGestiondeAsistenciasContext()
        {
        }

        public SistemadeGestiondeAsistenciasContext(DbContextOptions<SistemadeGestiondeAsistenciasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MEMO\\SERVER; Database=Sistema de Gestion de Asistencias ; Trusted_Connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.IdCargo)
                    .HasName("PK__Cargo__D3C09EC50AD8D85D");

                entity.Property(e => e.IdCargo)
                    .HasColumnName("id_cargo")
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreCargo)
                    .HasColumnName("nombre_cargo")
                    .IsUnicode(false);

                entity.Property(e => e.SuledoHora)
                    .HasColumnName("suledoHora")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.Property(e => e.IdPais)
                    .HasColumnName("id_pais")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.IdPersonal)
                    .HasName("PK_SGA_Personal");

                entity.Property(e => e.IdPersonal).HasColumnName("id_personal");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .IsUnicode(false);

                entity.Property(e => e.IdCargo).HasColumnName("id_cargo");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.Identificacion)
                    .HasColumnName("identificacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .IsUnicode(false);

                entity.Property(e => e.SueldoHora)
                    .HasColumnName("sueldoHora")
                    .HasColumnType("numeric(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
