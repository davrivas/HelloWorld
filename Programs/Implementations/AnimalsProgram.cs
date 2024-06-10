using HelloWorld.Constants;
using HelloWorld.Helpers;
using HelloWorld.Interfaces;
using HelloWorld.Models;

namespace HelloWorld.Programs.Implementations;

public class AnimalsProgram : IProgram
{
    public void Run()
    {
        var animals = new List<Animal>();
        int @continue;

        do {
            Console.WriteLine("Select animal:");
            Console.WriteLine("1.\tDog");
            Console.WriteLine("2.\tCat");
            var option = ConsoleHelpers.GetInt();

            Animal newAnimal = option switch {
                1 => new Dog(),
                2 => new Cat(),
                _ => throw new NotImplementedException($"Invalid animal: {option}")
            };

            newAnimal.Name = ConsoleHelpers.GetString("Enter animal's name");
            newAnimal.Height = ConsoleHelpers.GetDouble("Enter animal's height");
            newAnimal.Weight = ConsoleHelpers.GetDouble("Enter animal's weight");
            animals.Add(newAnimal);

            @continue = ConsoleHelpers.GetInt("Press 1 to add a new animal");
        } while (@continue == 1);

        Console.WriteLine("List of animals:");
        Console.WriteLine(AppConstants.SeparationLines);
        Console.WriteLine();

        foreach (var animal in animals)
        {
            Console.WriteLine($"Specie: {animal.GetType().Name}");
            Console.WriteLine($"Name: {animal.Name}");
            Console.WriteLine($"Height: {animal.Height}m");
            Console.WriteLine($"Weight: {animal.Weight}kg");
            Console.WriteLine(AppConstants.SeparationLines);
        }
    }
}