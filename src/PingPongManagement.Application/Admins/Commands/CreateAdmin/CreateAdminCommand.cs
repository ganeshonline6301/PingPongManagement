using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Admins;

namespace PingPongManagement.Application.Admins.Commands.CreateAdmin;

public record CreateAdminCommand(string firstName, string lastName, string email, string userName) : IRequest<ErrorOr<Admin>>;