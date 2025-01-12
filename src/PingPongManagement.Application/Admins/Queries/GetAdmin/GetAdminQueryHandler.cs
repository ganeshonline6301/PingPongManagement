using MediatR;
using ErrorOr;
using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Admins;

namespace PingPongManagement.Application.Admins.Queries.GetAdmin;

public class GetAdminQueryHandler : IRequestHandler<GetAdminQuery, ErrorOr<Admin>>
{
    private readonly IAdminRepository _adminRepository;

    public GetAdminQueryHandler(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }
    public async Task<ErrorOr<Admin>> Handle(GetAdminQuery request, CancellationToken cancellationToken)
    {
        var admin = await _adminRepository.GetByIdAsync(request.Id, cancellationToken);

        return admin is null
            ? Error.NotFound(description: "Admin not found")
            : admin;
    }
}