using Ardalis.SmartEnum;

namespace PingPongManagement.Domain.Tournaments;

public class TournamentFormat : SmartEnum<TournamentFormat>
{
    private TournamentFormat(string name, int value) : base(name, value)
    {
    }
    
    public static readonly TournamentFormat RoundRobin =  new(nameof(RoundRobin), 1);
    public static readonly TournamentFormat Knockout =  new(nameof(Knockout), 2);
    public static readonly TournamentFormat Swiss =  new(nameof(Swiss), 3);
    public static readonly TournamentFormat Mixed = new(nameof(Mixed), 4);

}