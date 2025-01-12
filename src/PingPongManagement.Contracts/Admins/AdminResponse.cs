namespace PingPongManagement.Contracts.Admins;

public record AdminResponse(Guid Id, string FirstName, string LastName, string Email, string UserName, Guid UserId);