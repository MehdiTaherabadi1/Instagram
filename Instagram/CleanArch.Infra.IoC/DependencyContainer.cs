using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domin.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<ICourseServices, CourseServics>();
            service.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
