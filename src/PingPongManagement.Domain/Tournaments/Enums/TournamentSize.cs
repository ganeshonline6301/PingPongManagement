using Ardalis.SmartEnum;

namespace PingPongManagement.Domain.Tournaments.Enums;

public class TournamentSize : SmartEnum<TournamentSize>
{
    private TournamentSize(string name, int value) : base(name, value)
    {
        
    }
    
    public static readonly TournamentSize Small = new(nameof(Small), 1);
    public static readonly TournamentSize Mid = new(nameof(Mid), 2);
    public static readonly TournamentSize Large = new(nameof(Large), 3);
    
}