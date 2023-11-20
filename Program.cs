using Microsoft.EntityFrameworkCore;
using Projeto.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure the DbContext and add it to the services.
builder.Services.AddDbContext<AppDataContext>(
    options => options.UseSqlite("Data Source=projeto.db;Cache=shared")
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseCors
(
c => c.AllowAnyOrigin()
);
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

