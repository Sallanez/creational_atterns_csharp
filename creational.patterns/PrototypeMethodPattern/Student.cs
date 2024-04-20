namespace creational.patterns.PrototypeMethodPattern;

//ConcretePrototype2
public class Student : Person
{
    
    public Student(string name, Teacher teacher) : base(name)
    {
        Teacher = teacher;
    }
    public Teacher Teacher { get; set; }
    public override Person Clone()
    {
        return (Person)MemberwiseClone();
    }

}
