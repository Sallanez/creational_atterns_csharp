namespace creational.patterns.PrototypeMethodPattern.TestExercise;

public abstract class SportProfessional
{
    protected SportProfessional(string name, string sport)
    {
        Name = name;
        Sport = sport;
    }

    public string Name { get; set; }
    public string Sport { get; set; }

    public abstract SportProfessional Clone();
}
