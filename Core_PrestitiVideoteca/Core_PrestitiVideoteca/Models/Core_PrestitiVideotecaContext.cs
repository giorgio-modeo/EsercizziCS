using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core_PrestitiVideoteca.Models
{
    public partial class Core_PrestitiVideotecaContext : DbContext
    {
        public Core_PrestitiVideotecaContext()
        {
        }

        public Core_PrestitiVideotecaContext(DbContextOptions<Core_PrestitiVideotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<Prestito> Prestitos { get; set; } = null!;
        public virtual DbSet<Studente> Studentes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=BSI-2224-14\\MSSQLSERVER01;Database=Core_PrestitiVideoteca;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.Codice)
                    .HasName("PK_TitoliExcel");

                entity.ToTable("Film");

                entity.Property(e => e.Attori).IsUnicode(false);

                entity.Property(e => e.Genere).HasMaxLength(50);

                entity.Property(e => e.Regista).IsUnicode(false);

                entity.Property(e => e.Supporto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titolo).IsUnicode(false);
            });

            modelBuilder.Entity<Prestito>(entity =>
            {
                entity.ToTable("Prestito");

                entity.Property(e => e.DataPrestito).HasColumnType("datetime");

                entity.Property(e => e.DataRestituzione).HasColumnType("datetime");

                entity.HasOne(d => d.IdFilmNavigation)
                    .WithMany(p => p.Prestiti)
                    .HasForeignKey(d => d.IdFilm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestito_TitoliExcel");

                entity.HasOne(d => d.MatricolaNavigation)
                    .WithMany(p => p.Prestitos)
                    .HasForeignKey(d => d.Matricola)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestito_Studente");
            });

            modelBuilder.Entity<Studente>(entity =>
            {
                entity.HasKey(e => e.Matricola);

                entity.ToTable("Studente");

                entity.Property(e => e.Matricola).ValueGeneratedNever();

                entity.Property(e => e.Classe).HasMaxLength(50);

                entity.Property(e => e.Cognome).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Nome).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
