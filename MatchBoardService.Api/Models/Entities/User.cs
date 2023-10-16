using System.Reflection.Metadata;

namespace MatchBoardService.Api.Models.Entities;

public class User : IEntity
{
    public Guid Id { get; set; }

    public string UserName { get; set; } = String.Empty;

    public List<Guid> LikedTeams { get; set; } = new();
}
