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
        private readonly ApplicationDbContext _db;

        public CoffeeController(ApplicationDbContext db) //constructer
        {
            _db = db;
        }

        public async Task DeleteCoffee(int id)
        {
            var data = await GetCoffeeById(id);

            await Task.Run(() => _db.Coffee.Remove(data));
        }

        public async Task<Coffee> GetCoffeeById(int id)
        {
            var data = await Task.Run(() =>
                _db.Coffee
                    .Where(x => x.Id.Equals(id))
                    .Select(coffee => new Coffee
                    {
                        Id = coffee.Id,
                        Name = coffee.Name
                    })
                    .ToList());

            return data;
        }

        public async Task<List<Coffee>> GetCoffees()
        {
            var data = await Task.Run(() =>
                _db.Coffee
                    .Select(coffee => new Coffee
                    {
                        Id = coffee.Id,
                        Name = coffee.Name
                    })
                    .ToList());

            return data;
        }

        public async Task InsertCoffee(Coffee data)
        {
            await Task.Run(() => _db.Coffee.AddAsync(data));
        }

        public async Task UpdateCoffee(Coffee data)
        {
            await Task.Run(() => _db.Coffee.Update(data));
        }


    }
}
