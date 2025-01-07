using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Tournaments.Queries.GetTournament;

public record GetTournamentQuery(Guid TournamentId) : IRequest<ErrorOr<Tournament>>;