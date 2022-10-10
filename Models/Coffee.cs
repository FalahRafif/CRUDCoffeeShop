using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cofiel.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Size { get; set; }
    }
}
