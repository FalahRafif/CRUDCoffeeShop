using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cofiel.Models;
using Cofiel.Models.Ef;

namespace Cofiel
{
    public class ApplicationDbContext : DbContext
    {
        //add-migration -v || generate script sql
        //update-database  || generate/update database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //regis fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CoffeeEF());
        }

        //regist model
        public DbSet<Coffee> Coffee { get; set; }
    }
}
