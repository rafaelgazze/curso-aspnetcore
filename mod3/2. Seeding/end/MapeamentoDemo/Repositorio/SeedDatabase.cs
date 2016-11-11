using MapeamentoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapeamentoDemo.Repositorio
{
    public static class SeedDatabase
    {
        public static void Initialize(EscolaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alunos.Any())
                return;

            var alunos = new List<Aluno>
            {
                new Aluno { Nome = "Albert Einstein" },
                new Aluno { Nome = "Marie Curie" },
                new Aluno { Nome = "Miguel Nicolelis" },
                new Aluno { Nome = "Galileo Galilei" },
            };

            context.Alunos.AddRange(alunos);
            context.SaveChanges();
        }
    }
}
