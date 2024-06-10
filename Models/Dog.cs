using HelloWorld.Interfaces;

namespace HelloWorld.Models;

public class Dog : Animal
{
    protected override string Sound => "woof!";
}