using MatchBoardService.Api.Models.Entities;

namespace MatchBoardService.Api.Events
{
    public class MatchEventStore
    {
        public event Func<TeamMatch, ValueTask>? OnMatchCreated;

        public async ValueTask<TeamMatch> CreateTeamMatchCreatedAsync(TeamMatch match)
        {
            //raise , invoke, create event - eventni chiqarish
            if (OnMatchCreated != null)
                await OnMatchCreated(match);
            return match;
        }
    }
}
