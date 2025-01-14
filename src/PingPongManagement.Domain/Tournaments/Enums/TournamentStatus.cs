using Ardalis.SmartEnum;

namespace PingPongManagement.Domain.Tournaments.Enums;

public class TournamentStatus : SmartEnum<TournamentStatus>
{
    private TournamentStatus(string name, int value) : base(name, value)
    {

    }

    public static readonly TournamentStatus Opened = new(nameof(Opened), 1);
    public static readonly TournamentStatus Closed = new(nameof(Closed), 2);
    public static readonly TournamentStatus NotStarted = new(nameof(NotStarted), 3);
    public static readonly TournamentStatus InProgress = new(nameof(InProgress), 4);
    public static readonly TournamentStatus Finished = new(nameof(Finished), 5);
    public static readonly TournamentStatus Cancelled = new(nameof(Cancelled), 6);
    public static readonly TournamentStatus Postponed = new(nameof(Postponed), 7);
}