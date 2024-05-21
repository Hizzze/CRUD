using PersonCrud.Contracts;
using PersonCrud.Core.Models;

namespace PersonCrud.Abstractions;

public interface IPersonRepository
{
    Task<List<Person>> Get(CancellationToken ct);
    Task<Person> GetById(Guid id, CancellationToken ct);
    Task<Person> Create(string firstName, string lastName, int age, CancellationToken ct);
    Task<Person> Edit(Guid id, PersonEditRequest request, CancellationToken ct);
    Task<Guid> Delete(Guid id, CancellationToken ct);
}