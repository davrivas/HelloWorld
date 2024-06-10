namespace HelloWorld.Models;

public class Person
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    public string? FullName => $"{Name} {LastName}";
}