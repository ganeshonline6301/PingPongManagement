using ErrorOr;
using MediatR;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Matches.Commands.CreateMatch;

public record CreateMatchCommand(string Name, string Description, MatchType MatchType) : IRequest<ErrorOr<Success>>;