using ErrorOr;
using MediatR;
using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Admins;

namespace PingPongManagement.Application.Admins.Commands.CreateAdmin;

public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommand, ErrorOr<Admin>>
{
    private readonly IAdminRepository _adminRepository;

    public CreateAdminCommandHandler(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }
    public async Task<ErrorOr<Admin>> Handle(CreateAdminCommand command, CancellationToken cancellationToken)
    {
        var admin = new Admin(
            firstName: command.firstName,
            lastName: command.lastName,
            email: command.email,
            userName: command.userName,
            userId: Guid.NewGuid(),
            playerId: Guid.NewGuid());
        
        await _adminRepository.AddAsync(admin, cancellationToken);
        return admin;
    }
}