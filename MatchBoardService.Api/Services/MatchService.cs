using MatchBoardService.Api.Events;
using MatchBoardService.Api.Models.Entities;

namespace MatchBoardService.Api.Services;

public class MatchService : IEntityService
{
    private readonly MatchEventStore _matchEventStore;
    public List<TeamMatch> Matches { get; } = new();

    public MatchService(MatchEventStore matchEventStore)
    {
        _matchEventStore = matchEventStore;
    }

    public async ValueAsync<TeamMatch> CreateAsync(TeamMatch match)
    {
        Matches.Add(match);
        await _matchEventStore.CreateTeamMatchCreatedAsync(match);
        return match;
    }

}
