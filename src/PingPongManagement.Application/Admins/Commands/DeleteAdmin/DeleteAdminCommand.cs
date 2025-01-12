using ErrorOr;
using MediatR;

namespace PingPongManagement.Application.Admins.Commands.DeleteAdmin;

public record DeleteAdminCommand(Guid Id): IRequest<ErrorOr<Deleted>>;