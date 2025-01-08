using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Commands.CreateTournament;

public record CreateTournamentCommand(string Title, string Description, TournamentType TournamentType, Guid AdminId) : IRequest<ErrorOr<Tournament>>;