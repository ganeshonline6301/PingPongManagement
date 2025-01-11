﻿using ErrorOr;
using PingPongManagement.Domain.Sets;

namespace PingPongManagement.Domain.Matches;

public class Match
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public MatchType MatchType { get; private set; }
    public MatchStatus Status { get; private set; }
    public Guid TournamentId { get; private set; }
    public Guid? WinnerId { get; private set; }
    
    private readonly List<Set> _sets = new List<Set>();
    public IReadOnlyCollection<Set> Sets => _sets.AsReadOnly();
    
    public Match(Guid id, string name, MatchType matchType, Guid tournamentId)
    {
        Id = id;
        Name = name;
        MatchType = matchType;
        TournamentId = tournamentId;
        Status = MatchStatus.NotStarted; // Default status when created
    }

    private Match()
    {
        
    }

    public ErrorOr<Success> StartMatch()
    {
        if (Status != MatchStatus.NotStarted)
        {
            return MatchErrors.MatchAlreadyStarted;
        }
        
        Status = MatchStatus.InProgress;
        
        return Result.Success;
    }
    
    public ErrorOr<Success> CompleteMatch(Guid winnerId)
    {
        if (Status == MatchStatus.Completed)
        {
            return MatchErrors.MatchAlreadyCompleted;
        }
        
        WinnerId = winnerId;
        Status = MatchStatus.Completed;
        
        return Result.Success;
    }

    public ErrorOr<Success> CancelMatch()
    {
        if (Status == MatchStatus.Completed)
        {
            return MatchErrors.CannotCancelCompletedMatch;
        }

        Status = MatchStatus.Cancelled;
        
        return Result.Success;
    }
}