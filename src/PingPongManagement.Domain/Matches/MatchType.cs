using Ardalis.SmartEnum;

namespace PingPongManagement.Domain.Matches;

public class MatchType : SmartEnum<MatchType>
{
    public static readonly MatchType RoundRobin = new(nameof(RoundRobin), 1);
    public static readonly MatchType Knockout = new(nameof(Knockout), 2);
    public static readonly MatchType Mixed = new(nameof(Mixed), 3);
    public MatchType(string name, int value) : base(name, value)
    {
        
    }
}