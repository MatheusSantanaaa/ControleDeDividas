using Desafio.Api.Applications.AutoMapper;
using Desafio.Api.Applications.Commands.Handlers;
using Desafio.Api.Applications.Commands.Models;
using Desafio.Api.Applications.Queries;
using Desafio.Core.Communication.Mediator;
using Desafio.Domain.Interfaces;
using Desafio.Infra.Data.Context;
using Desafio.Infra.Data.Repository;
using FluentValidation.Results;
using MediatR;

namespace Desafio.Api.Configurations
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //auto mapper
            services.AddAutoMapper(typeof(MappingHelperProfile));

            //Mediator
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            //Repository
            services.AddScoped<SystemContext>();
            services.AddScoped<IDividaRepository, DividaRepository>();

            // Application - Commands
            services.AddScoped<IRequestHandler<RegistrarDividaCommand, ValidationResult>, DividaCommandHandler>();
            services.AddScoped<IRequestHandler<AtualizarDividaCommand, ValidationResult>, DividaCommandHandler>();
            services.AddScoped<IRequestHandler<RemoverDividaCommand, ValidationResult>, DividaCommandHandler>();

            // Application - Queries
            services.AddScoped<IDividaQuerie, DividaQuerie>();
        }
    }
}
