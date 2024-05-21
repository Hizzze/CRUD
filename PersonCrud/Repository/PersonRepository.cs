using Microsoft.EntityFrameworkCore;
using PersonCrud.Abstractions;
using PersonCrud.Contracts;
using PersonCrud.Core.Models;
using PersonCrud.DataAccess;

namespace PersonCrud.Repository;

public class PersonRepository : IPersonRepository
{
    private readonly PersonDbContext _context;
    public PersonRepository(PersonDbContext context)
    {
        _context = context;
    }

    public async Task<List<Person>> Get(CancellationToken ct)
    {
        var person = await _context.Persons.ToListAsync(ct);

        return person;
    }
    
    public async Task<Person> GetById(Guid id, CancellationToken ct)
    {
        return await _context.Persons.FindAsync(new object[] { id }, ct);
    }

    public async Task<Person> Create(string firstName, string lastName, int age, CancellationToken ct)
    {
        var personEntity = new Person(firstName, lastName, age);
        
        await _context.Persons.AddAsync(personEntity, ct);
        await _context.SaveChangesAsync(ct);

        return personEntity;
    }

    public async Task<Person> Edit(Guid id, PersonEditRequest request, CancellationToken ct)
    {
        var person = await _context.Persons.FindAsync( id , ct);

        if (person == null)
        {
            throw new KeyNotFoundException("Person not found");
        }

        person.FirstName = request.FirstName;
        person.LastName = request.LastName;
        person.Age = request.Age;

        await _context.SaveChangesAsync(ct);

        return person;
    }

    public async Task<Guid> Delete(Guid id, CancellationToken ct)
    {
        var person = await _context.Persons
            .Where(p => p.Id == id)
            .ExecuteDeleteAsync(ct);

        return id;
    }
}