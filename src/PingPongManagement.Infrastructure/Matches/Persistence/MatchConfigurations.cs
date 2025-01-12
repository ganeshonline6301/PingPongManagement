using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PingPongManagement.Domain.Matches;
using MatchType = PingPongManagement.Domain.Matches.MatchType;

namespace PingPongManagement.Infrastructure.Matches.Persistence;

public class MatchConfigurations : IEntityTypeConfiguration<Match>
{
    public void Configure(EntityTypeBuilder<Match> builder)
    {
        builder.Property(m => m.MatchType)
            .HasConversion(
                matchType => matchType.Value,
                value => MatchType.FromValue(value));
    }
}