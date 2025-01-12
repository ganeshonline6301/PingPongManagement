using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PingPongManagement.Domain.Admins;
using PingPongManagement.Domain.Matches;
using PingPongManagement.Domain.Sets;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Infrastructure.Common;

public class PingPongManagementDbContext : DbContext
{
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<Set> Sets { get; set; }

    public PingPongManagementDbContext(DbContextOptions<PingPongManagementDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}