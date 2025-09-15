using Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Ajoutez cette ligne
builder.Services.AddOpenApi();
builder.Services.AddScoped<PlayerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Commentez temporairement la redirection HTTPS pour le développement
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
