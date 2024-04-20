using creational.patterns.AbstraactFactoryPattern.Interfaces;

namespace creational.patterns.AbstraactFactoryPattern.Objects;
public class Spanish : ILenguage
{
    //Concrete Product A2 
    public void Greet()
    {
        Console.WriteLine("Hola");
    }
}
