using BusinessLogic;
using DataAccess.Repositories;
using DataAccessInterface;
using IDataAccess.Interfaces;
using LogicInterface;
using LogicInterface.Interfaces;
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
    }
     
}