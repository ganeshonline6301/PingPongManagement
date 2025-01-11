using PingPongManagement.Domain.Admins;

namespace PingPongManagement.Domain.Sets;

public class Set
{
    public Guid Id { get; set; }
    public int SetNumber { get; set; }
    public Admin Winner { get; set; }
    public int Player1Score { get; set; }
    public int Player2Score { get; set; }
    public Guid MatchId { get; set; }
}