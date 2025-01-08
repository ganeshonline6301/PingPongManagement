using ErrorOr;
using MediatR;
using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Queries.GetTournament;

public class GetTournamentQueryHandler : IRequestHandler<GetTournamentQuery, ErrorOr<Tournament>>
{
    private readonly ITournamentRepository _tournamentRepository;

    public GetTournamentQueryHandler(ITournamentRepository tournamentRepository)
    {
        _tournamentRepository = tournamentRepository;
    }
    public async Task<ErrorOr<Tournament>> Handle(GetTournamentQuery request, CancellationToken cancellationToken)
    {
        var tournament = await _tournamentRepository.GetAsync(request.TournamentId, cancellationToken);

        return tournament is null
            ? Error.NotFound(description: "Tournament not found")
            : tournament;
    }
}