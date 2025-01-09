using ErrorOr;

namespace PingPongManagement.Domain.Tournaments;

public static class TournamentErrors
{
    public static readonly Error CannotIncludeMoreMatchesThanTheTournamentAllows = Error.Validation(
        code: "Tournament.CannotIncludeMoreMatchesThanTheTournamentAllows",
        description: "Tournament cannot include more matches to this tournament."); 
}