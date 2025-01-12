using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Admins;

namespace PingPongManagement.Application.Admins.Queries.GetAdmin;

public record GetAdminQuery(Guid Id) : IRequest<ErrorOr<Admin>>;