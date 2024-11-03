
using MentorProjectWebApp.Mappings;
using System.Reflection;

namespace MentorProjectWebApp.Configurations
{
        public class Configuration
    {

        public static void ConfigureServices(WebApplicationBuilder builder)

        {
                        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddAutoMapper(typeof(GeneralMapping));

        }

    }
}