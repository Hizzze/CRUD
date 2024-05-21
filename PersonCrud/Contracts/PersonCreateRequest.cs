namespace PersonCrud.Contracts;

public record PersonCreateRequest(string? FirstName, string? LastName, int Age);