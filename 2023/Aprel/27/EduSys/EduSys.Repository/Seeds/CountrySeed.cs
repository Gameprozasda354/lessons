using EduSys.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.Seeds
{
    public class CountrySeed : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { Id = 1, Name = "Azerbaijan", ShortName = "AZE" },
                new Country { Id = 2, Name = "Germany", ShortName = "GER" },
                new Country { Id = 3, Name = "United Kingdom", ShortName = "UK" }
                );
        }
    }
}
