using Ardalis.SmartEnum;

namespace PingPongManagement.Domain.Matches.Enums;

public class MatchStatus : SmartEnum<MatchStatus>
{
    public MatchStatus(string name, int value) : base(name, value)
    {
    }
    
    public static readonly MatchStatus NotStarted = new(nameof(NotStarted), 1);
    public static readonly MatchStatus InProgress = new(nameof(InProgress), 2);
    public static readonly MatchStatus Completed = new(nameof(Completed), 3);
    public static readonly MatchStatus Cancelled = new(nameof(Cancelled), 4);
}