using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MapeamentoDemo.Repositorio;
using MapeamentoDemo.Models;

namespace MapeamentoDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly Alunos _alunos;
        private readonly Cursos _cursos;

        public HomeController(Alunos alunos, Cursos cursos)
        {
            _alunos = alunos;
            _cursos = cursos;
        }

        public IActionResult Index()
        {
            var alunos = _alunos.Todos();
            var cursos = _cursos.Todos();

            var viewModel = new AlunosCursosViewModel(alunos, cursos);
            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
