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
                Id = 0,
                Name = "Kopi Hitam"
            },
            new Coffee
            {
                Id = 1,
                Name = "Kopi Abu-Abu"
            }
        };

        public void DeleteCoffee(int id)
        {
            var getCoffee = GetCoffeeById(id);
            _Coffees.Remove(getCoffee);
        }

        public Coffee GetCoffeeById(int id)
        {
            return _Coffees.SingleOrDefault(x => x.Id.Equals(id));
        }

        public List<Coffee> GetCoffees()
        {
            return _Coffees;
        }

        public void InsertCoffee(Coffee data)
        {
            var id = 3;
            data.Id = id;

            _Coffees.Add(data);
        }

        public void UpdateCoffee(Coffee data)
        {
            var getCoffee = GetCoffeeById(data.Id);
            getCoffee.Name = data.Name;
        }


    }
}
