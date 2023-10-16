namespace Events.Example.Api.Models.Entities;

public class BlogPost : IEntity
{
    public Guid Id { get; set; }

    public string Title { get; set; } = String.Empty;

    public List<string> Topic { get; set; } = new List<string>();

    public Guid AuthorId { get; set; }
}
