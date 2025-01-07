using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Queries.GetTournament;

public class GetTournamentQueryHandler : IRequestHandler<GetTournamentQuery, ErrorOr<Tournament>>
{
    public Task<ErrorOr<Tournament>> Handle(GetTournamentQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}