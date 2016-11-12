using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIFluente.Models;
using APIFluente.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace APIFluente.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdventureWorksContext _context;
        public HomeController(AdventureWorksContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult People()
        {
            var people = _context.Person
                                 .OrderBy(p => p.LastName)
                                 .Take(100);

            return View(people);
        }

        public IActionResult CustomersByTerritory()
        {
            var customersByTerritory = 
                            _context.Customers.Include(c => c.Person)
                                    .Where(c => !c.AccountNumber.EndsWith("1"))
                                    .OrderBy(c => c.AccountNumber)
                                    .ThenBy(c => c.ModifiedDate)
                                    .Skip(100)
                                    .GroupBy(c => c.TerritoryID)
                                    .Select(g => new CustomersByTerritory
                                    {
                                        TerritoryID = g.Key,
                                        Customers = g.Select(c => c).Take(10)
                                    });

            return View(customersByTerritory);
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
