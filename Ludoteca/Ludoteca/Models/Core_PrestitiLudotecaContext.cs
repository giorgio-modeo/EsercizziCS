using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ludoteca.Models
{
    public partial class Core_PrestitiLudotecaContext : DbContext
    {
        public Core_PrestitiLudotecaContext()
        {
        }

        public Core_PrestitiLudotecaContext(DbContextOptions<Core_PrestitiLudotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GiochiTavolo> GiochiTavolos { get; set; } = null!;
        public virtual DbSet<Prestiti> Prestitis { get; set; } = null!;
        public virtual DbSet<Tipologium> Tipologia { get; set; } = null!;
        public virtual DbSet<Utente> Utentes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=Core_PrestitiLudoteca;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiochiTavolo>(entity =>
            {
                entity.HasKey(e => e.IdGioco);

                entity.ToTable("GiochiTavolo");

                entity.Property(e => e.Denominazione)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione).HasColumnType("text");

                entity.Property(e => e.DurataPartita)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtàGiocatori)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroGiocatori)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PezziDisponibili)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdTipologiaNavigation)
                    .WithMany(p => p.GiochiTavolos)
                    .HasForeignKey(d => d.IdTipologia)
                    .HasConstraintName("FK_GiochiTavolo_Tipologia");
            });

            modelBuilder.Entity<Prestiti>(entity =>
            {
                entity.HasKey(e => e.IdPrestito);

                entity.ToTable("Prestiti");

                entity.Property(e => e.DataPrestito).HasColumnType("date");

                entity.Property(e => e.DataRestituzione).HasColumnType("date");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.HasOne(d => d.IdGiocoNavigation)
                    .WithMany(p => p.Prestitis)
                    .HasForeignKey(d => d.IdGioco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestiti_GiochiTavolo");
            });

            modelBuilder.Entity<Tipologium>(entity =>
            {
                entity.HasKey(e => e.IdTipologia);

                entity.Property(e => e.Tipologia)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Utente>(entity =>
            {
                entity.HasKey(e => e.CodiceFiscale);

                entity.ToTable("Utente");

                entity.Property(e => e.CodiceFiscale)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cap)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Città)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cognome)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.DataNascita).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Indirizzo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.LuogoNascita)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Provincia)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPrestitoNavigation)
                    .WithMany(p => p.Utentes)
                    .HasForeignKey(d => d.IdPrestito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Utente_Prestiti");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
