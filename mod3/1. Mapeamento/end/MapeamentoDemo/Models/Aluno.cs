using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapeamentoDemo.Models
{
    public class Aluno
    {
        //O EF exige uma propriedade que seja PK na tabela.
        //Por convenção, Id ou AlunoId já serão consideradas.
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
