namespace PingPongManagement.Domain.Matches;

public class Match
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public MatchType MatchType { get; set; }
    public Guid TournamentId { get; set; }
    public Guid WinnerId { get; set; }
}