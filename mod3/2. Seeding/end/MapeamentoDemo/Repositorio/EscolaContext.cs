using MapeamentoDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapeamentoDemo.Repositorio
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                        .ToTable("Aluno")
                        .Property(a => a.Nome).HasColumnName("NomeCompleto");
        }
    }
}
