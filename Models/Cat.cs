using HelloWorld.Interfaces;

namespace HelloWorld.Models;

public class Cat : Animal
{
    protected override string Sound => "meow!";
}