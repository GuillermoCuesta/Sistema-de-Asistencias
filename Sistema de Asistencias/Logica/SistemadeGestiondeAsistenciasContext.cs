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

        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MEMO\\SERVER; Database=Sistema de Gestion de Asistencias; User=sa; Password=2109; Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asistencia>(entity =>
            {
                entity.HasKey(e => e.IdAsistencia)
                    .HasName("PK_Asistencias");

                entity.Property(e => e.IdAsistencia).HasColumnName("id_asistencia");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEntrada)
                    .HasColumnName("Fecha_entrada")
                    .HasColumnType("date");

                entity.Property(e => e.FechaSalida)
                    .HasColumnName("Fecha_salida")
                    .HasColumnType("date");

                entity.Property(e => e.HoraEntrada)
                    .HasColumnName("Hora_entrada")
                    .HasColumnType("time(0)");

                entity.Property(e => e.HoraSalida)
                    .HasColumnName("Hora_salida")
                    .HasColumnType("time(0)");

                entity.Property(e => e.Horas).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IdPersonal).HasColumnName("id_personal");

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.Asistencia)
                    .HasForeignKey(d => d.IdPersonal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asistencias_Personal");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.IdCargo)
                    .HasName("PK__Cargo__D3C09EC50AD8D85D");

                entity.Property(e => e.IdCargo).HasColumnName("id_cargo");

                entity.Property(e => e.NombreCargo)
                    .HasColumnName("nombre_cargo")
                    .IsUnicode(false);

                entity.Property(e => e.SueldoHora)
                    .HasColumnName("sueldoHora")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo);

                entity.Property(e => e.IdModulo).HasColumnName("id_modulo");

                entity.Property(e => e.Modulo1)
                    .HasColumnName("modulo")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasKey(e => new { e.IdModulo, e.IdUsuario })
                    .HasName("PK_Permiso_1");

                entity.Property(e => e.IdModulo).HasColumnName("id_modulo");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.Permiso)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permiso_Modulo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Permiso)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permiso_Usuario");
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

                entity.Property(e => e.Foto).HasColumnName("foto");

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

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personal_Cargo");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personal_Pais");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Contraseña)
                    .HasColumnName("contraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icono).HasColumnName("icono");

                entity.Property(e => e.NombreApellido)
                    .HasColumnName("nombreApellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario1)
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
