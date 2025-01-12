using System.Security.Cryptography.X509Certificates;

namespace PingPongManagement.Contracts.Admins;

public record CreateAdminRequest(string firstName, string lastName, string email, string UserName);