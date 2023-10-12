namespace Events.Example;

public class PostService
{
    private readonly PostEventStore _eventstore;
    public PostService(PostEventStore eventStore)
    {
        _eventstore = eventStore;        
    }

    public async ValueTask<Post> Create(Post post)
    {
        //postni bazaga yozish qismi

        await _eventstore.CreatePostAddedEventAsync(post);
        return post;
    }
}
