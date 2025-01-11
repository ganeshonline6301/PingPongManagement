namespace PingPongManagement.Domain.Admins;

public class Admin
{
    public Guid Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string UserName { get; }
    public Guid UserId { get; }
    public Guid PlayerId { get; }

    public Admin(string firstName, string lastName, string email, string userName, Guid userId, Guid playerId, Guid? id = null)
    {
         FirstName = firstName;
         LastName = lastName;
         Email = email;
         UserName = userName;
         UserId = userId;
         PlayerId = playerId;
         Id = id ?? Guid.NewGuid();
    }
    
    private Admin() { }
}