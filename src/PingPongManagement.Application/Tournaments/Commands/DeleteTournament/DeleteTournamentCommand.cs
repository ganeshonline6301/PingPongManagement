using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Commands.DeleteTournament;

public record DeleteTournamentCommand(Guid TournamentId) : IRequest<ErrorOr<Tournament>>;