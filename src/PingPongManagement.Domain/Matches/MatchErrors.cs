using ErrorOr;

namespace PingPongManagement.Domain.Matches;

public static class MatchErrors
{
    public static readonly Error MatchAlreadyStarted = Error.Validation(
        code:"Match.MatchAlreadyStarted",
        description:"The match has already started and cannot be started again."
    );

    public static readonly Error MatchNotInProgress = Error.Validation(
        code:"Match.MatchNotInProgress",
        description:"The match must be in progress to perform this action."
    );

    public static readonly Error MatchAlreadyCompleted = Error.Validation(
        code:"Match.MatchAlreadyCompleted",
        description:"The match has already been completed and cannot be modified."
    );

    public static readonly Error MatchAlreadyCancelled = Error.Validation(
        code:"Match.MatchAlreadyCancelled",
        description:"The match has already been cancelled and cannot be modified."
    );

    public static readonly Error CannotCancelCompletedMatch = Error.Validation(
        code:"Match.CannotCancelCompletedMatch",
        description:"A match that has been completed cannot be cancelled."
    );

    public static readonly Error InvalidWinner = Error.Validation(
        code:"Match.InvalidWinner",
        description:"The provided winner ID is invalid for this match."
    );

    public static readonly Error InvalidSetForMatch = Error.Validation(
        code:"Match.InvalidSetForMatch",
        description:"The provided set does not belong to this match."
    );
}