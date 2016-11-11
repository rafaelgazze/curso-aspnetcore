using MapeamentoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapeamentoDemo.Repositorio
{
    public class Alunos
    {
        private static IEnumerable<Aluno> _alunos = 
            new[]
            {
                new Aluno { Nome = "Patolino" },
                new Aluno { Nome = "Pernalonga" },
            };

        public IEnumerable<Aluno> Todos() => _alunos;
    }
}
