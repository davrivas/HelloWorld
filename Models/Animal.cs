namespace HelloWorld.Interfaces;

public abstract class Animal
{
    public string? Name { get; set; }
    public double Height { get; set; }
    public double Weight {  get; set; }

    protected abstract string Sound { get; }

    public void MakeSound()
    {
        Console.WriteLine(Sound);
    }
}