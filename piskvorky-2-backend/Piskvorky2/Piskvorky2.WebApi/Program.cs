using Piskvorky2.Domain;
using Piskvorky2.Repositories.Models;
using Piskvorky2.Repositories.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("Database"));

/**
 * TODO move this into extension in Repositories project
 * TODO remove reference to Repositories project
 * 
 */
builder.Services.AddSingleton<PlayersRepository>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


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
