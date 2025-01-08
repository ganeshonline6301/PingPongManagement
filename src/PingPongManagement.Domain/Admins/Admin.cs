namespace PingPongManagement.Domain.Admins;

public class Admin
{
    public Guid Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string UserName { get; }
    public Guid UserId { get; }

    public Admin(string firstName, string lastName, string email, string userName, Guid userId, Guid? id = null)
    {
         FirstName = firstName;
         LastName = lastName;
         Email = email;
         UserName = userName;
         UserId = userId;
         Id = id ?? Guid.NewGuid();
    }
    
    private Admin() { }
}