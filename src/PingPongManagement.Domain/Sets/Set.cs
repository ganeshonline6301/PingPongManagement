namespace PingPongManagement.Domain.Sets;

public class Set
{
    public Guid Id { get; set; }
    public byte SetOrder { get; set; }
    public Guid MatchId { get; set; }
}