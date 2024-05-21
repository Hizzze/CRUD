using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PersonCrud.Abstractions;
using PersonCrud.Contracts;
using PersonCrud.Core.Models;

namespace PersonCrud.Controllers;

[ApiController]
[Route("Persons")]
public class PersonController : ControllerBase
{
    private readonly IPersonRepository _personRepository;
    public PersonController(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken ct)
    {
        var persons = await _personRepository.Get(ct);

        if (persons == null) return BadRequest();
        return Ok(persons);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPersonById(Guid id, CancellationToken ct)
    {
        var person = await _personRepository.GetById(id, ct);
        if (person == null)
        {
            return NotFound();
        }
        return Ok(person);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePerson([FromBody]PersonCreateRequest request,CancellationToken ct)
    {
        var personCreate = await _personRepository.Create(request.FirstName, request.LastName, request.Age, ct);
        
        return Ok(personCreate);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditPerson(Guid id, [FromBody] PersonEditRequest request, CancellationToken ct)
    {
        var personEdit = await _personRepository.Edit(id, request, ct);
        return Ok(personEdit);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(Guid id, CancellationToken ct)
    {
        var person = _personRepository.Delete(id, ct);

        if (person == null) return BadRequest();

        return Ok(id);
    } 
}
