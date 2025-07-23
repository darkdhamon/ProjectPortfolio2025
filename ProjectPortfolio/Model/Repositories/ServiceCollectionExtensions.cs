using Microsoft.Extensions.DependencyInjection;

namespace Model.Repositories;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IProfileRepository, ProfileRepository>();
        return services;
    }
}
