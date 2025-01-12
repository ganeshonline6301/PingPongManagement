using ErrorOr;
using MediatR;

namespace PingPongManagement.Application.Admins.Commands.UpdateAdmin;

public class UpdateAdminCommandHandler : IRequestHandler<UpdateAdminCommand, ErrorOr<Updated>>
{
    public Task<ErrorOr<Updated>> Handle(UpdateAdminCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}













