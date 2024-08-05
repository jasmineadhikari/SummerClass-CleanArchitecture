using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestProject.Application.Common.Interface;
using TestProject.Infrastructure.Persistance;
using TestProject.Infrastructure.Service;

namespace TestProject.Infrastructure;

public static class ConfigureService
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("SummerClassDatabasePostgreSQL"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)),
            ServiceLifetime.Transient);
    
        services.AddTransient<IEmployeeService, EmployeeService>();
        services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
        
        return services;
    }
}