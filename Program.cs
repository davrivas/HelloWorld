using HelloWorld.Helpers;
using HelloWorld.Programs;
using HelloWorld.Programs.Implementations;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Select program:");
            Console.WriteLine("1.\tPerson name");
            Console.WriteLine("2.\tAnimals");
            var option = ConsoleHelpers.GetInt();

            IProgram program = option switch
            {
                1 => new PersonNameProgram(),
                2 => new AnimalsProgram(),
                _ => throw new NotImplementedException($"Invalid program: {option}")
            };
            program.Run();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
