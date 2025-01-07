using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Commands.DeleteTournament;

public class DeleteTournamentCommandHandler : IRequestHandler<DeleteTournamentCommand, ErrorOr<Tournament>>
{
    public Task<ErrorOr<Tournament>> Handle(DeleteTournamentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}