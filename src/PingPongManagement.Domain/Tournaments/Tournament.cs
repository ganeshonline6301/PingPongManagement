﻿using ErrorOr;
using PingPongManagement.Domain.Common;
using PingPongManagement.Domain.Matches;
using PingPongManagement.Domain.Tournaments.Enums;
using Throw;

namespace PingPongManagement.Domain.Tournaments;

public class Tournament : Entity
{
    private readonly List<Guid> _matchIds = new();
    private readonly int _maxMatches;
    public string Title { get; private set; }
    public TournamentType Type { get; private set; }
    public TournamentFormat Format { get; private set; }
    public TournamentSize Size { get; private set; }
    public TournamentStatus Status { get; private set; }
    public string Description { get; private set; }
    public DateTime StartDate { get; private set; }
    public Guid AdminId { get; private set; }
    
    public IReadOnlyCollection<Guid> Matches => _matchIds.AsReadOnly();

    public Tournament(string title, string description, TournamentType type, TournamentStatus status, TournamentFormat format, TournamentSize size, DateTime startDate, Guid adminId, Guid? id = null) : base(id ?? Guid.NewGuid())
    {
        Type = type;
        Status = status;
        Format = format;
        Title = title;
        Size = size;
        Description = description;
        StartDate = startDate;
        AdminId = Guid.NewGuid();
    }

    private Tournament()
    {
        
    }

    public ErrorOr<Success> AddMatch(Match match, Guid player1Id, Guid player2Id)
    {
        _matchIds.Throw().IfContains(match.Id);

        if (_matchIds.Count == 48)
        {
            return TournamentErrors.CannotIncludeMoreMatchesThanTheTournamentAllows;
        }

        if (player1Id.Equals(AdminId) || player2Id.Equals(AdminId))
        {
            return TournamentErrors.TournamentOwnerCannotbeParticipate;
        }
        
        _matchIds.Add(match.Id);

        return Result.Success;
    }
    
    public bool HasMatch(Guid gymId)
    {
        return _matchIds.Contains(gymId);
    }
}