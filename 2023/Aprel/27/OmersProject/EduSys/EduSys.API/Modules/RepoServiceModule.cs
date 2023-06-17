﻿using Autofac;
using EduSys.Caching;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using EduSys.Repository;
using EduSys.Repository.Repositories;
using EduSys.Repository.UnitOfWork;
using EduSys.Service.Mapping;
using EduSys.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace EduSys.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(serviceAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            //builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();

            builder.RegisterGeneric(typeof(GenericRepository<>))
                .As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Service<>))
                .As(typeof(IService<>))
                .InstancePerLifetimeScope();

			builder.RegisterGeneric(typeof(ServiceWithDto<,>))
				.As(typeof(IServiceWithDto<,>))
				.InstancePerLifetimeScope();

			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

			builder.RegisterType<ProductServiceWithDto>().As<IProductServiceWithDto>().InstancePerLifetimeScope();

			//Api project
			//https:7212
			//http:5212

			//Web project
			//https:7183
			//http:5183
		}
	}
}
