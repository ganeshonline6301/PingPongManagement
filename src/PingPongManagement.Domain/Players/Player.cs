namespace PingPongManagement.Domain.Players;

public class Player
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Guid UserId { get; set; }
}