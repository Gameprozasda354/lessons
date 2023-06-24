using EduSys.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.Configurations
{
	public class CountryConfiguration : IEntityTypeConfiguration<Country>
	{
		public void Configure(EntityTypeBuilder<Country> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id).UseIdentityColumn(1, 1);

			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

			builder.Property(x => x.ShortName).IsRequired().HasMaxLength(3);

			builder.ToTable("Countries");
		}
	}
}
