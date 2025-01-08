namespace PingPongManagement.Domain.Tournaments;

public class Tournament
{
    public Guid Id { get; }
    public string Title { get; }
    public TournamentType Type { get; }
    public string Description { get; }
    public Guid AdminId { get; }

    public Tournament(string title, string description, TournamentType type, Guid adminId, Guid? id = null)
    {
        Type = type;
        Title = title;
        Description = description;
        AdminId = adminId;
        Id = id ?? Guid.NewGuid();
    }
}