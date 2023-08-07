using BusinessLogic;
using LogicInterface.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceFactory
{
    public static class ServiceFactory
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMovieLogic, MovieLogic>();
        }
    }
     
}