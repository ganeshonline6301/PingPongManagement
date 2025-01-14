using ErrorOr;
using MediatR;
using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Commands.CreateTournament;

public class CreateTournamentCommandHandler : IRequestHandler<CreateTournamentCommand, ErrorOr<Tournament>>
{
    private readonly ITournamentRepository _tournamentRepository;
    private readonly IAdminRepository _adminRepository;

    public CreateTournamentCommandHandler(ITournamentRepository tournamentRepository, IAdminRepository adminRepository)
    {
        _tournamentRepository = tournamentRepository;
        _adminRepository = adminRepository;
    }
    public async Task<ErrorOr<Tournament>> Handle(CreateTournamentCommand request, CancellationToken cancellationToken)
    {
        var admin = await _adminRepository.GetByIdAsync(request.AdminId, cancellationToken);
        
        if (admin is null)
        {
            return Error.NotFound(description: "Admin not found");
        }

        var tournament = new Tournament(
            title: request.Title,
            description: request.Description,
            type: request.TournamentType,
            status: request.TournamentStatus,
            format: request.TournamentFormat,
            size: request.TournamentSize,
            startDate: request.StartDate,
            adminId: admin.Id,
            id: Guid.NewGuid()
        );
        
        
        await _tournamentRepository.AddAsync(tournament, cancellationToken);

        return tournament;
    }
}