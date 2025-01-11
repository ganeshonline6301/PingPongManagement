using ErrorOr;

namespace PingPongManagement.Domain.Sets;

public static class SetErrors
{
    public static readonly Error InvalidScores = Error.Validation(
        code: "Set.InvalidScores",
        description: "Scores cannot be equal. There must be a winner for the set."
    );
    
    public static readonly Error PlayersNotAssigned = Error.Validation(
        code: "Set.PlayersNotAssigned",
        description: "Players must be assigned before recording scores."
    );
    
    public static readonly Error SetAlreadyCompleted = Error.Validation(
        code: "Set.SetAlreadyCompleted",
        description: "Scores cannot be updated. The set is already complete."
    );
}