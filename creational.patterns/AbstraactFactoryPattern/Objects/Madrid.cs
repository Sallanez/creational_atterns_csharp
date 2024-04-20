using creational.patterns.AbstraactFactoryPattern.Interfaces;

namespace creational.patterns.AbstraactFactoryPattern.Objects;

public class Madrid : ICapitalCity
{
    public int GetPopulation()
    {
        return 3200000;
    }

    public List<string> ListTopAttraction()
    {
        return
        [
            "Museo del Prado",
            "Parque del Retiro",
            "Palacio Real",
            "Plaza Mayor"
        ];
    }
}
