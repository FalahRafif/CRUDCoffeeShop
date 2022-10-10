using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cofiel.Models.Ef
{
    public class CoffeeEF : IEntityTypeConfiguration<Coffee>
    {
        public void Configure(EntityTypeBuilder<Coffee> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(pk => pk.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Name);
        }
    }
}
