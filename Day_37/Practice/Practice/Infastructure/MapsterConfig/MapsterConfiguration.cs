using Mapster;
using Practice.Models;
using Practice.Models.DTOs;
using System.Reflection;

namespace Practice.Infastructure.MapsterConfig
{
    public static class MapsterConfiguration
    {
        public static void RegisterMapsterConfiguration(this IServiceCollection services)
        {
            TypeAdapterConfig<Person, PersonDTO>
                .NewConfig(); 

            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        }
    }
}
