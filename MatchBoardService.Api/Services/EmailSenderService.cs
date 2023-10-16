namespace MatchBoardService.Api.Services;

public class EmailSenderService
{
    public ValueTask SendAsync(Guid userId, string content)
    {
        Console.WriteLine($"Sending email to {userId} with content {content}");

        return new ValueTask();
    }
}
