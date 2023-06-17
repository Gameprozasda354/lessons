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
    public class CitySeed : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { Id = 1, Name = "Baku", CountryId = 1 },
                new City { Id = 2, Name = "Sumgait", CountryId = 1 },
                new City { Id = 3, Name = "Ganja", CountryId = 1 }
                );
        }
    }
}
