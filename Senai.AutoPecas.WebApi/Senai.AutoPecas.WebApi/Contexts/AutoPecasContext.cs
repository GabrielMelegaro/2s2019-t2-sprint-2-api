using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.AutoPecas.WebApi.Domains
{
    public partial class AutoPecasContext : DbContext
    {
        public AutoPecasContext()
        {
        }

        public AutoPecasContext(DbContextOptions<AutoPecasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fornecedores> Fornecedores { get; set; }
        public virtual DbSet<Pecas> Pecas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=T_AutoPecas;User Id=sa;Pwd=132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedores>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor);

                entity.Property(e => e.Cnpj).HasColumnName("CNPJ");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(235)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasMaxLength(430)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Fornecedores)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Fornecedo__IdUsu__4BAC3F29");
            });

            modelBuilder.Entity<Pecas>(entity =>
            {
                entity.HasKey(e => e.IdPeca);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(960)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.Pecas)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK__Pecas__IdFornece__4E88ABD4");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(215)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(230)
                    .IsUnicode(false);
            });
        }
    }
}
