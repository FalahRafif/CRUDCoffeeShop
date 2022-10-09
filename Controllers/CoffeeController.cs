using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cofiel.Models;
using Cofiel.Services;

namespace Cofiel.Controllers
{
    public class CoffeeController : ICoffeeService
    {
        private List<Coffee> _Coffees = new List<Coffee>
        {
            new Coffee
            {
                Id = Guid.NewGuid(),
                Name = "Kopi Hitam"
            },
            new Coffee
            {
                Id = Guid.NewGuid(),
                Name = "Kopi Abu-Abu"
            }
        };

        public List<Coffee> GetCoffees()
        {
            return _Coffees;
        }
    }
}
