using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cofiel.Models;

namespace Cofiel.Services
{
    interface ICoffeeService
    {
        Task<List<Coffee>> GetCoffees();

        Task<Coffee> GetCoffeeById(int id);

        Task UpdateCoffee(Coffee data);

        Task InsertCoffee(Coffee data);

        Task DeleteCoffee(int id);
    }
}
