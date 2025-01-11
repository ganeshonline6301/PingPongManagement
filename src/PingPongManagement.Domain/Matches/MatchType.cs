using Ardalis.SmartEnum;

namespace PingPongManagement.Domain.Matches;

public class MatchType : SmartEnum<MatchType>
{
    public MatchType(string name, int value) : base(name, value)
    {
        
    }
    
    public static readonly MatchType RoundRobin = new(nameof(RoundRobin), 1);
    public static readonly MatchType Knockout = new(nameof(Knockout), 2);
}