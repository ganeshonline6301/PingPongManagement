using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Infrastructure.Admins.Persistence;
using PingPongManagement.Infrastructure.Common;
using PingPongManagement.Infrastructure.Matches.Persistence;
using PingPongManagement.Infrastructure.Tournaments.Persistence;

namespace PingPongManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services.AddPersistence();
    }

    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<PingPongManagementDbContext>(options =>
        {
            options.UseSqlite("Data Source=PingPongManagement.db");
        });

        services.AddScoped<IAdminRepository, AdminRepository>();
        services.AddScoped<ITournamentRepository, TournamentRepository>();
        services.AddScoped<IMatchRepository, MatchRepository>();
        
        return services;
    }
}