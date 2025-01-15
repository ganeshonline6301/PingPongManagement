using PingPongManagement.Contracts.Tournaments.Enums;

namespace PingPongManagement.Contracts.Tournaments;

public record CreateTournamentRequest(
    string Title,
    string Description,
    DateTime StartDate,
    TournamentType TournamentType,
    TournamentStatus TournamentStatus,
    TournamentFormat TournamentFormat,
    TournamentSize TournamentSize);