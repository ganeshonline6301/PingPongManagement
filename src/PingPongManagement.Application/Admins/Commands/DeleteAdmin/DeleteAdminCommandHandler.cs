using ErrorOr;
using MediatR;
using PingPongManagement.Application.Common.Interfaces;

namespace PingPongManagement.Application.Admins.Commands.DeleteAdmin;

public class DeleteAdminCommandHandler : IRequestHandler<DeleteAdminCommand, ErrorOr<Deleted>>
{
    private readonly IAdminRepository _adminRepository;

    public DeleteAdminCommandHandler(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }
    public async Task<ErrorOr<Deleted>> Handle(DeleteAdminCommand command, CancellationToken cancellationToken)
    {
        var admin = await _adminRepository.GetByIdAsync(command.Id, cancellationToken);

        if (admin is null)
        {
            return Error.NotFound(description: "Admin not found");
        }
        
        await _adminRepository.DeleteAsync(command.Id, cancellationToken);
        
        return Result.Deleted;
    }
}