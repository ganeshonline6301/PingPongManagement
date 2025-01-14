using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Tournaments;
using PingPongManagement.Domain.Tournaments.Enums;

namespace PingPongManagement.Application.Tournaments.Commands.CreateTournament;

public record CreateTournamentCommand(string Title, string Description, TournamentType TournamentType, TournamentStatus TournamentStatus, TournamentFormat TournamentFormat, DateTime StartDate, Guid AdminId) : IRequest<ErrorOr<Tournament>>;