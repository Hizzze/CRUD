using Microsoft.EntityFrameworkCore;
using PersonCrud.Abstractions;
using PersonCrud.DataAccess;
using PersonCrud.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddDbContext<PersonDbContext>(opt => opt
    .UseNpgsql(builder.Configuration.GetConnectionString(nameof(PersonDbContext))));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();



app.Run();

