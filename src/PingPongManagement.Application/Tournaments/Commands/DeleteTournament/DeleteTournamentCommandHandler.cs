using ErrorOr;
using MediatR;
using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Commands.DeleteTournament;

public class DeleteTournamentCommandHandler : IRequestHandler<DeleteTournamentCommand, ErrorOr<Deleted>>
{
    private readonly ITournamentRepository _tournamentRepository;

    public DeleteTournamentCommandHandler(ITournamentRepository tournamentRepository)
    {
        _tournamentRepository = tournamentRepository;
    }
    public async Task<ErrorOr<Deleted>> Handle(DeleteTournamentCommand command, CancellationToken cancellationToken)
    {
        var tournament = await _tournamentRepository.GetAsync(command.TournamentId, cancellationToken);
        
        if (tournament is null)
        {
            return Error.NotFound(description: "Tournament not found");
        }
        await _tournamentRepository.RemoveAsync(command.TournamentId, cancellationToken);

        return Result.Deleted;
    }
}