using creational.patterns.AbstraactFactoryPattern.Interfaces;
using creational.patterns.AbstraactFactoryPattern.Objects;

namespace creational.patterns.AbstraactFactoryPattern;

public class InternationalProvider
{
    public static IInternationalFactory Create(Country country)
    {
        return country switch
        {
            Country.England => new  EnglandFactory(),
            Country.Spain => new SpainFactory(),
            _ => throw new NotSupportedException($"{country} not yet supported.")
        };
    }
}
