using ErrorOr;
using MediatR;

namespace PingPongManagement.Application.Admins.Commands.UpdateAdmin;

public record UpdateAdminCommand(Guid Id, string firstName) : IRequest<ErrorOr<Updated>>;