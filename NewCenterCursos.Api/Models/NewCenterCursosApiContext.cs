using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewCenterCursos.Api.Models
{
    public partial class NewCenterCursosApiContext : DbContext
    {
        public NewCenterCursosApiContext()
        {
        }

        public NewCenterCursosApiContext(DbContextOptions<NewCenterCursosApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Faleconosco> Faleconoscos { get; set; } = null!;
        public virtual DbSet<Matricula> Matriculas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=newcentercursos_api;uid=root;pwd=kE@laqJLl#1DM", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.15-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Faleconosco>(entity =>
            {
                entity.ToTable("faleconosco");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Assunto)
                    .HasMaxLength(200)
                    .HasColumnName("assunto");

                entity.Property(e => e.Celular)
                    .HasMaxLength(45)
                    .HasColumnName("celular");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(200)
                    .HasColumnName("cidade");

                entity.Property(e => e.Datacadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("datacadastro");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasMaxLength(200)
                    .HasColumnName("estado");

                entity.Property(e => e.Mensagem).HasColumnName("mensagem");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(45)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Matricula>(entity =>
            {
                entity.ToTable("matriculas");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(200)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasMaxLength(45)
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(200)
                    .HasColumnName("cidade");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(200)
                    .HasColumnName("complemento");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(45)
                    .HasColumnName("cpf");

                entity.Property(e => e.Curso)
                    .HasMaxLength(200)
                    .HasColumnName("curso");

                entity.Property(e => e.Datacadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("datacadastro");

                entity.Property(e => e.Datanascimento)
                    .HasMaxLength(10)
                    .HasColumnName("datanascimento");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasMaxLength(200)
                    .HasColumnName("estado");

                entity.Property(e => e.Logradouro)
                    .HasMaxLength(200)
                    .HasColumnName("logradouro");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("nome");

                entity.Property(e => e.Nomemae)
                    .HasMaxLength(200)
                    .HasColumnName("nomemae");

                entity.Property(e => e.Nomeresponsavel)
                    .HasMaxLength(200)
                    .HasColumnName("nomeresponsavel");

                entity.Property(e => e.Rg)
                    .HasMaxLength(45)
                    .HasColumnName("rg");

                entity.Property(e => e.Telefoneresponsavel)
                    .HasMaxLength(45)
                    .HasColumnName("telefoneresponsavel");

                entity.Property(e => e.Whatsapp)
                    .HasMaxLength(45)
                    .HasColumnName("whatsapp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
