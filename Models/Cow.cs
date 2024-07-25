using HelloWorld.Interfaces;

namespace HelloWorld.Models
{
    public class Cow : Animal
    {
        protected override string Sound => "moo!";
    }
}
