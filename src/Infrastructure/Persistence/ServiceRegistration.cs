using System;
using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => {
                opt.UseSqlServer("Server=127.0.0.1,1433;Database=funtranslatedb;Trust Server Certificate=true; User=sa; Password=842862432156.sql;");
            });

            serviceCollection.AddTransient<ITranslateRequestRepository, TranslateRequestRepository>();
            serviceCollection.AddTransient<ITranslateResponseRepository, TranslateResponseRepository>();
            serviceCollection.AddTransient<IRequestUrlRepository, RequestUrlRepository>();
        }
    }
}

