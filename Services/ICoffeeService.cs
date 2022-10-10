﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cofiel.Models;

namespace Cofiel.Services
{
    interface ICoffeeService
    {
        List<Coffee> GetCoffees();

        Coffee GetCoffeeById(Guid id);

        void UpdateCoffee(Coffee data);

        void InsertCoffee(Coffee data);

        void DeleteCoffee(Guid id);
    }
}
