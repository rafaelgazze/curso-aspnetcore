using MapeamentoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapeamentoDemo.Repositorio
{
    public class Cursos
    {
        private static IEnumerable<Curso> _cursos =
            new[]
            {
                new Curso { Nome = "ASP.NET Core" },
                new Curso { Nome = "Xamarin" },
            };

        public IEnumerable<Curso> Todos() => _cursos;
    }
}
