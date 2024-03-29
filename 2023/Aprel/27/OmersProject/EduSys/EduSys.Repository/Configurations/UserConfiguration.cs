﻿using EduSys.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
			builder.Property(x => x.SurName).IsRequired().HasMaxLength(50);
			builder.Property(x => x.EmailAddress).IsRequired().HasMaxLength(255);
			builder.Property(x => x.DateOfBirth).IsRequired();
			builder.Property(x => x.Password).IsRequired().HasMaxLength(200);
			builder.Property(x => x.IsActive).IsRequired();
			builder.Property(x => x.CountryId).IsRequired();
			builder.ToTable("Users");

			builder.HasOne(x => x.Country).WithMany(x => x.User).HasForeignKey(x => x.CountryId);
		}
	}
}
