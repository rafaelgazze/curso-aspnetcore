using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MapeamentoDemo.Repositorio;
using MapeamentoDemo.Models;
using System.Net.Http;
using System.Net;

namespace MapeamentoDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly EscolaContext _context;

        public HomeController(EscolaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var alunos = _context.Alunos.ToList();

            var viewModel = new AlunosCursosViewModel
            {
                Alunos = alunos
            };

            return View(viewModel);
        }

        public async Task<HttpResponseMessage> AdicionarAluno(string nome)
        {
            _context.Alunos.Add(new Aluno { Nome = nome });
            await _context.SaveChangesAsync();
            return new HttpResponseMessage(HttpStatusCode.Created);
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
