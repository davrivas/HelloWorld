using HelloWorld.Helpers;
using HelloWorld.Models;

namespace HelloWorld.Programs.Implementations;

public class PersonNameProgram : IProgram
{
    public void Run()
    {
        var person = new Person
        {
            Name = ConsoleHelpers.GetString("What is your name?"),
            LastName = ConsoleHelpers.GetString("What is your last name?"),
            Age = ConsoleHelpers.GetInt("What is your age?")
        };
        
        Console.WriteLine($"You are {person.FullName} and you are {person.Age} years old");
    }
}