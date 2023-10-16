namespace MatchBoardService.Api.Services;

public class SmsSenderService
{
    public ValueTask SendAsync(Guid userId, string content)
    {
        Console.WriteLine($"Sending sms to {userId} with content {content}");
        return new ValueTask();
    }
}
