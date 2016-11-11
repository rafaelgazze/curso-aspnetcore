using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapeamentoDemo.Models
{
    public class AlunosCursosViewModel
    {
        public AlunosCursosViewModel()
        {

        }

        public AlunosCursosViewModel(IEnumerable<Aluno> alunos, IEnumerable<Curso> cursos)
        {
            this.Alunos = alunos;
            this.Cursos = cursos;
        }

        public IEnumerable<Aluno> Alunos { get; set; } = new List<Aluno>();
        public IEnumerable<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
