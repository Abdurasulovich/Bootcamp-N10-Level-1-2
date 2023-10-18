using MatchBoardService.Api.Events;
using MatchBoardService.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder
    .Services
    .AddSingleton<MatchEventStore>()
    .AddSingleton<MatchService>()
    .AddSingleton<UsersService>()
    .AddSingleton<PromotionService>()
    .AddSingleton<TeamService>()
    .AddSingleton<INotificationService, EmailSenderService>()
    .AddSingleton<INotificationService, SmsSenderService>();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
