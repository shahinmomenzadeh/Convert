using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Service;
using WebApplication1.db;
using WebApplication1.db.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//var connectionString = builder.Configuration.GetConnectionString("Db");
//builder.Services.AddDbContext<Db>(options => Options.UseSqlServer(connectionString));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Result>();

#region Adding Services

builder.Services.AddScoped<TestService>();

builder.Services.AddScoped<Cmtoinch>();
builder.Services.AddScoped<Mailtokilometr>();
#endregion
    
builder.Services.AddDbContext<Db>(oBuilder =>
    oBuilder.UseSqlServer("Server=localhost;Database=DBCONVERT;User Id=tnt;Password=1;encrypt=false;"));


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