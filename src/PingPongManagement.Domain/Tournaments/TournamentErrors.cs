using OneOf.Types;
using Error = ErrorOr.Error;

namespace PingPongManagement.Domain.Tournaments;

public static class TournamentErrors
{
    public static readonly Error CannotIncludeMoreMatchesThanTheTournamentAllows = Error.Validation(
        code: "Tournament.CannotIncludeMoreMatchesThanTheTournamentAllows",
        description: "Tournament cannot include more matches to this tournament.");

    public static readonly Error TournamentOwnerCannotbeParticipate = Error.Validation(
        code: "Tournament.TournamentOwnerCannotbeParticipate",
        description: "The admin cannot participate in their own tournament.");
}