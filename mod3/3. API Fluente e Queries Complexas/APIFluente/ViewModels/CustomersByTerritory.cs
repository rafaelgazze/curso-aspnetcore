using APIFluente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFluente.ViewModels
{
    public class CustomersByTerritory
    {
        public int? TerritoryID { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
