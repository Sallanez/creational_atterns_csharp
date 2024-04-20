using creational.patterns.AbstraactFactoryPattern.Interfaces;

namespace creational.patterns.AbstraactFactoryPattern.Objects;

//Concrete Product A1
public class English : ILenguage
{
    public void Greet()
    {
        Console.WriteLine("Hello");
    }
}
