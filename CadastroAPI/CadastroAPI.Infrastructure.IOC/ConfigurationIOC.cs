using Autofac;
using AutoMapper;
using CadastroAPI.Application.Interfaces;
using CadastroAPI.Application.Mappers;
using CadastroAPI.Application.Services;
using CadastroAPI.Domain.Core.Interfaces.Repositorys;
using CadastroAPI.Domain.Core.Interfaces.Services;
using CadastroAPI.Domain.Services.Services;
using CadastroAPI.Infrastructure.Data.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAPI.Infrastructure.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IAppServicePessoaFisica>().As<IAppServiceFisica>();
            builder.RegisterType<IAppServicePessoaJuridica>().As<IAppServiceJuridica>();
            builder.RegisterType<ServicePessoaFisica>().As<IServiceFisica>();
            builder.RegisterType<ServicePessoaJuridica>().As<IServiceJuridica>();
            builder.RegisterType<RepositoryFisica>().As<IRepositoryPessoaFisica>();
            builder.RegisterType<RepositoryJuridica>().As<IRepositoryPessoaJuridica>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperPessoa());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
