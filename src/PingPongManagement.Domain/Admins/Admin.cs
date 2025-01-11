namespace PingPongManagement.Domain.Admins;

public class Admin
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string UserName { get; private set; }
    public Guid UserId { get; private set; }
    public Guid PlayerId { get; private set; }

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