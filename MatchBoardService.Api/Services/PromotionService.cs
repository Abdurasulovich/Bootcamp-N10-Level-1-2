using MatchBoardService.Api.Events;
using MatchBoardService.Api.Models.Entities;

namespace MatchBoardService.Api.Services;

public class PromotionService
{
    private readonly MatchEventStore _matchEventStore;
    private readonly IEnumerable<INotificationService> _notificationService;
    private readonly UsersService _usersService;

    public PromotionService(MatchEventStore matchEventStore, IEnumerable<INotificationService> notificationService, UsersService usersService)
    {
        _matchEventStore = matchEventStore;
        _notificationService = notificationService;
        _usersService = usersService;

        _matchEventStore.OnMatchCreated += HandleTeamMatchCreatedEventAsync;
    }

    private async ValueTask HandleTeamMatchCreatedEventAsync(TeamMatch teamMatch)
    {
        var userQuery = _usersService.Users.Where(user=>user.LikedTeams.Any(teamId=>teamId == teamMatch.TeamA | teamId == teamMatch.TeamB));
        var users = userQuery.ToList();


        var notifyUsersTask = users.Select(user => Task.WhenAll(_notificationService
            .Select(notificationService => notificationService
            .SendAsync(user.Id, $"Match between {teamMatch.TeamA} and {teamMatch.TeamB} will start at {teamMatch.MatchTime}").AsTask())));

        await Task.WhenAll(notifyUsersTask);
    }
}
