namespace creational.patterns.PrototypeMethodPattern.TestExercise;

public class Player : SportProfessional
{
    public Player(string name, string sport, string position, Coach coach) : base(name, sport)
    {
        Position = position;
        Coach = coach;
    }
    public string Position { get; set; }
    public Coach Coach { get; set; }
    public override SportProfessional Clone()
    {
        return (SportProfessional)this.MemberwiseClone();
    }
}
