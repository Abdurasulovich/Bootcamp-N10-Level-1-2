using static Events.Example.DiscoveryService;

namespace Events.Example;

public class DiscoveryService
{
    private readonly PostEventStore _eventStore;
    public DiscoveryService(PostEventStore postEventStore)
    {
        _eventStore = postEventStore;
        _eventStore.OnPostCreated += HandlePostCreatedEventAsync;
    }

    public ValueTask HandlePostCreatedEventAsync(Post post)
    {
        // var value = new List<UserPreferences>();
        //
        // var userPreferences = value.Where(userPreference => userPreference.Topics.Contains(post.Topic)).ToList();
        
        Console.WriteLine($"Notifiying users who like the topic - {post}");
        return new ValueTask();
    }

    public class UserPreference
    {
        public List<string> Topics { get; set; } = new List<string>();
    }
}
