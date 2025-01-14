using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PingPongManagement.Domain.Matches;
using PingPongManagement.Domain.Matches.Enums;

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