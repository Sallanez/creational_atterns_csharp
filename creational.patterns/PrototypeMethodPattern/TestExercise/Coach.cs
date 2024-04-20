namespace creational.patterns.PrototypeMethodPattern.TestExercise;

public class Coach : SportProfessional
{
    public Coach(string name, string sport, string coachingStyle) : base(name, sport)
    {
        CoachingStyle = coachingStyle;
    }
    public string CoachingStyle { get; set; }
    public override SportProfessional Clone()
    {
        return (SportProfessional)MemberwiseClone();
    }
}
