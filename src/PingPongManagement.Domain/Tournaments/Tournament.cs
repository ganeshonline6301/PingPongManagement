namespace PingPongManagement.Domain.Tournaments;

public class Tournament
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public TournamentType Type { get; set; }
    public string Description { get; set; }
}