using creational.patterns.AbstraactFactoryPattern.Interfaces;

namespace creational.patterns.AbstraactFactoryPattern.Objects;

public class London : ICapitalCity
{
    public int GetPopulation()
    {
        return 8900000;
    }

    public List<string> ListTopAttraction()
    {
        return
        [
            "Tower of London",
            "Buckingham Palace",
            "The British Museum",
            "Big Ben"
        ];
    }
}
