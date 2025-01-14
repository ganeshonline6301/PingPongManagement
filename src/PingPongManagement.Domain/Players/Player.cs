namespace PingPongManagement.Domain.Players;

public class Player
{
    public Guid Id { get; }
    public string Code { get; }
    public Guid UserId { get; }
    public Guid TournamentId { get; }

    public Player()
    {
        
    }
}