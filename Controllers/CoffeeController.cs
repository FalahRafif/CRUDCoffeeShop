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

            _db.Coffee.Remove(data);
            await _db.SaveChangesAsync();
        }

        public async Task<Coffee> GetCoffeeById(int id)
        {
            var data = await Task.Run(() =>
                _db.Coffee
                    .Where(x => x.Id.Equals(id))
                    .Select(coffee => new Coffee
                    {
                        Id = coffee.Id,
                        Name = coffee.Name,
                        Size = coffee.Size                        
                    })
                    .FirstOrDefault());

            return data;
        }

        public async Task<List<Coffee>> GetCoffees()
        {
            var data = await Task.Run(() =>
                _db.Coffee
                    .Select(coffee => new Coffee
                    {
                        Id = coffee.Id,
                        Name = coffee.Name,
                        Size = coffee.Size
                    })
                    .ToList());

            return data;
        }

        public async Task InsertCoffee(Coffee data)
        {
            _db.Coffee.Add(data);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateCoffee(Coffee data)
        {
            _db.Coffee.Update(data);
            await _db.SaveChangesAsync();
        }


    }
}
