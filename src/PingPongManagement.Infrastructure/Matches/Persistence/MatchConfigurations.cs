using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PingPongManagement.Domain.Matches;

namespace PingPongManagement.Infrastructure.Matches.Persistence;

public class MatchConfigurations : IEntityTypeConfiguration<Match>
{
    public void Configure(EntityTypeBuilder<Match> builder)
    {
        builder.Property(m => m.Status)
            .HasConversion(
                status => status.Value,
                value => MatchStatus.FromValue(value));
    }
}