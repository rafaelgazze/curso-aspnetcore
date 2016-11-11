using MapeamentoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapeamentoDemo.Repositorio
{
    public static class SeedDatabaseDev
    {
        public static void Initialize(EscolaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alunos.Any())
                return;

            var alunos = new List<Aluno>
            {
                new Aluno { Nome = "Patolino" },
                new Aluno { Nome = "Pernalonga" },
                new Aluno { Nome = "Coiote" },
                new Aluno { Nome = "Papaléguas" },
            };

            context.Alunos.AddRange(alunos);
            context.SaveChanges();
        }
    }
}
