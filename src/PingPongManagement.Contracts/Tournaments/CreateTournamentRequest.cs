namespace PingPongManagement.Contracts.Tournaments;

public record CreateTournamentRequest(string Title, string Description, DateTime StartDate, DateTime EndDate);