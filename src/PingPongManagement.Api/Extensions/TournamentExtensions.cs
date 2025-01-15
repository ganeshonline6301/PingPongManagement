using Microsoft.OpenApi.Extensions;
using PingPongManagement.Contracts.Tournaments.Enums;
using DomainTournamentType = PingPongManagement.Domain.Tournaments.Enums.TournamentType;
using DomainTournamentStatus = PingPongManagement.Domain.Tournaments.Enums.TournamentStatus;
using DomainTournamentFormat = PingPongManagement.Domain.Tournaments.Enums.TournamentFormat;
using DomainTournamentSize = PingPongManagement.Domain.Tournaments.Enums.TournamentSize;

namespace PingPongManagement.Api.Extensions;


public static class TournamentExtensions
{
    internal static TournamentType ToDto(DomainTournamentType tournamentType)
    {
        return tournamentType.Name switch
        {
            nameof(DomainTournamentType.Single) => TournamentType.Single,
            nameof(DomainTournamentType.Double) => TournamentType.Double,
            nameof(DomainTournamentType.Team) => TournamentType.Team,
            nameof(DomainTournamentType.MixedDouble) => TournamentType.MixedDoubles,
            _ => throw new InvalidOperationException(),
        };   
    }

    internal static DomainTournamentType ToDomain(this TournamentType tournamentType)
    {
        return tournamentType.GetDisplayName() switch
        {
            nameof(TournamentType.Single) => DomainTournamentType.Single,
            nameof(TournamentType.Double) => DomainTournamentType.Double,
            nameof(TournamentType.Team) => DomainTournamentType.Team,
            nameof(TournamentType.MixedDoubles) => DomainTournamentType.MixedDouble,
            _ => throw new InvalidOperationException(),
        };
    }
    
    internal static TournamentStatus ToDto(DomainTournamentStatus tournamentType)
    {
        return tournamentType.Name switch
        {
            nameof(DomainTournamentStatus.Opened) => TournamentStatus.Opened,
            nameof(DomainTournamentStatus.Closed) => TournamentStatus.Closed,
            nameof(DomainTournamentStatus.NotStarted) => TournamentStatus.NotStarted,
            nameof(DomainTournamentStatus.InProgress) => TournamentStatus.InProgress,
            nameof(DomainTournamentStatus.Finished) => TournamentStatus.Finished,
            nameof(DomainTournamentStatus.Cancelled) => TournamentStatus.Cancelled,
            nameof(DomainTournamentStatus.Postponed) => TournamentStatus.Postponed,
            _ => throw new InvalidOperationException(),
        };   
    }

    internal static DomainTournamentStatus ToDomain(this TournamentStatus tournamentType)
    {
        return tournamentType.GetDisplayName() switch
        {
            nameof(TournamentStatus.Opened) => DomainTournamentStatus.Opened,
            nameof(TournamentStatus.Closed) => DomainTournamentStatus.Closed,
            nameof(TournamentStatus.NotStarted) => DomainTournamentStatus.NotStarted,
            nameof(TournamentStatus.InProgress) => DomainTournamentStatus.InProgress,
            nameof(TournamentStatus.Finished) => DomainTournamentStatus.Finished,
            nameof(TournamentStatus.Cancelled) => DomainTournamentStatus.Cancelled,
            nameof(TournamentStatus.Postponed) => DomainTournamentStatus.Postponed,
            _ => throw new InvalidOperationException(),
        };
    }
}