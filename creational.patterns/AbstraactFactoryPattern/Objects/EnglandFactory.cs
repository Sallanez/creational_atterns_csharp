using creational.patterns.AbstraactFactoryPattern.Interfaces;

namespace creational.patterns.AbstraactFactoryPattern.Objects;

public class EnglandFactory : IInternationalFactory
{
    public ICapitalCity CreateCapitalCity()
    {
        return new London();
    }

    public ILenguage CreateLenguage()
    {
        return new English();
    }
}
