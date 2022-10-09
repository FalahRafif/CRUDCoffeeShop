using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cofiel.Models
{
    public class ApplicationDbContext : DbContext
    {
        //add-migration -v || generate script sql
        //update-database  || generate/update database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //regist model
        public DbSet<Coffee> Coffee { get; set; }
    }
}
