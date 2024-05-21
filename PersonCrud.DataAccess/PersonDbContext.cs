using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PersonCrud.Core.Models;

namespace PersonCrud.DataAccess;

public class PersonDbContext : DbContext
{

    public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Person> Persons { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
}