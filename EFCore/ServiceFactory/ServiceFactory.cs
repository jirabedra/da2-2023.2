using BusinessLogic;
using DataAccess.Context;
using DataAccess.Repositories;
using DataAccessInterface;
using IDataAccess.Interfaces;
using LogicInterface;
using LogicInterface.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceFactory
{
    public static class ServiceFactory
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMovieRepository, MovieRepository>();
            serviceCollection.AddScoped<IReviewRepository, ReviewRepository>();
            serviceCollection.AddScoped<IMovieLogic, MovieLogic>();
            serviceCollection.AddScoped<IReviewLogic, ReviewLogic>();
        }

        public static void AddConnectionString(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<DbContext, MoviesContext>(o => o.UseSqlServer(connectionString));
        }
    }
     
}