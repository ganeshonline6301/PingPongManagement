using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Infrastructure.Tournaments.Persistence;

public class TournamentConfigurations : IEntityTypeConfiguration<Tournament>
{
    public void Configure(EntityTypeBuilder<Tournament> builder)
    {
        builder.HasKey(T  => T.Id);
        
        builder.Property(m => m.Type)
            .HasConversion(
                type => type.Value,
                value => TournamentType.FromValue(value));
        
        builder.Property(m => m.Status)
            .HasConversion(
                status => status.Value,
                value => TournamentStatus.FromValue(value));
    }
}