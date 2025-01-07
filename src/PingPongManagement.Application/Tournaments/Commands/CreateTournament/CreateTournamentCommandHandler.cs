using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Commands.CreateTournament;

public class CreateTournamentCommandHandler : IRequestHandler<CreateTournamentCommand, ErrorOr<Tournament>>
{
    public Task<ErrorOr<Tournament>> Handle(CreateTournamentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}