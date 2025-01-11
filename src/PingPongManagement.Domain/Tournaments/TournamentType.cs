using Ardalis.SmartEnum;

namespace PingPongManagement.Domain.Tournaments;

public class TournamentType : SmartEnum<TournamentType>
{
    public TournamentType(string name, int value) : base(name, value)
    {
        
    }
    
    public static readonly TournamentType Single = new(nameof(Single), 1);
    public static readonly TournamentType Double = new(nameof(Double), 2);
    public static readonly TournamentType Team = new(nameof(Team), 3);
    public static readonly TournamentType MixedDouble = new(nameof(MixedDouble), 4);
}
