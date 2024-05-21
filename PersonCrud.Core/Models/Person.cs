using System.ComponentModel.DataAnnotations;

namespace PersonCrud.Core.Models;

public class Person
{

    public Person(string  firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    public Guid Id { get; init; }
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public int Age { get; set; }
}