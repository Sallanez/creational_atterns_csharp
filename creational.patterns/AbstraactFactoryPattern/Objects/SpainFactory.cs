using creational.patterns.AbstraactFactoryPattern.Interfaces;

namespace creational.patterns.AbstraactFactoryPattern.Objects;

public class SpainFactory : IInternationalFactory
{
    public ICapitalCity CreateCapitalCity()
    {
        return new Madrid();
    }

    public ILenguage CreateLenguage()
    {
        return new Spanish();
    }
}
