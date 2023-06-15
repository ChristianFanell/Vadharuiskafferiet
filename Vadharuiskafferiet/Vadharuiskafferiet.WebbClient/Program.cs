using Microsoft.EntityFrameworkCore;
using Vadharuiskafferiet.Application.Ingredients.Queries;
using Vadharuiskafferiet.Application.Recepies.Query;
using Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities;
using Vadharuiskafferiet.Persistence;
using Vadharuiskafferiet.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var dbConnectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<RecepieDbContext>(options =>
{
    options.UseSqlServer(dbConnectionString);
});

builder.Services.AddTransient<IRepository<Recepie>, RecepieRepository>();
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(
        typeof(GetIngredientsHandler).Assembly,
        typeof(GetIngredientsQuery).Assembly,
        typeof(GetRecepiesHandler).Assembly,
        typeof(GetRecepiesQuery).Assembly
        );
});


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
