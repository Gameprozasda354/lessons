﻿using EduSys.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
            foreach(var item in ChangeTracker.Entries())
            {
                if(item.Entity is BaseEntity entityReference)
                {
                    switch(item.State)
                    {
                        case EntityState.Added:
                            {
								Entry(entityReference).Property(x => x.UpdatedDate).IsModified = false;
								entityReference.CreatedDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                entityReference.UpdatedDate = DateTime.Now;
                                break;
                            }
                    }
                }
            }

			return base.SaveChangesAsync(cancellationToken);
		}

		public override int  SaveChanges()
		{
			foreach (var item in ChangeTracker.Entries())
			{
				if (item.Entity is BaseEntity entityReference)
				{
					switch (item.State)
					{
						case EntityState.Added:
							{

								Entry(entityReference).Property(x => x.UpdatedDate).IsModified = false;
								entityReference.CreatedDate = DateTime.Now;
								break;
							}
						case EntityState.Modified:
							{
								Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
								entityReference.UpdatedDate = DateTime.Now;
								break;
							}
					}
				}
			}

			return base.SaveChanges();
		}

	}
}
