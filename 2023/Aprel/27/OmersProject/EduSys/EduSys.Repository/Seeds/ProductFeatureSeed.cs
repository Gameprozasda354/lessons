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
	public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
	{
		public void Configure(EntityTypeBuilder<ProductFeature> builder)
		{
			builder.HasData(
				new ProductFeature
				{
					Id = 1,
					Color = "Red",
					Height = 30,
					Width = 70,
					ProductId = 1
				},
				new ProductFeature
				{
					Id = 2,
					Color = "Red",
					Height = 20,
					Width = 25,
					ProductId = 3
				},
				new ProductFeature
				{
					Id = 3,
					Color = "Red",
					Height = 80,
					Width = 40,
					ProductId = 2
				}
				);
		}
	}
}
