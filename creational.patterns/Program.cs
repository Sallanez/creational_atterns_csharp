using creational.patterns.AbstraactFactoryPattern;
using creational.patterns.AbstraactFactoryPattern.Interfaces;
using creational.patterns.AbstraactFactoryPattern.Objects;
using creational.patterns.Builder;
using creational.patterns.FactoryMethodPattern;
using creational.patterns.PrototypeMethodPattern;
using creational.patterns.PrototypeMethodPattern.TestExercise;
using creational.patterns.SingletonPattern;

//Patter: Factory Method
IPaymnet payment = PaymentFactory.Create(PaymentMethod.CreditCard);
payment.Pay(1000.00);

//Patter: Abstract Factory
Country country = Country.England;
IInternationalFactory factory = InternationalProvider.Create(country);
ILenguage lenguage = factory.CreateLenguage();
ICapitalCity capital = factory.CreateCapitalCity();
lenguage.Greet();
Console.WriteLine("Total population: " + capital.GetPopulation());
Console.WriteLine("Top Attraction:" + string.Join(",", capital.ListTopAttraction()));
//Console.ReadKey();

//Patter: Builder
//Director
Email email = new EmailBuilder()
   .AddFrom("info@cambelltech.co.zaa")
   .AddTo("sam@gmail.com")
   .AddTo("jane@yahoo.com")
   .AddCc("jone@cambelltech.io")
   .WithSubject("Test Email")
   .WithBody("Hello, this is a test email")
   .AddAttachment("attachment1.pdf")
   .Build();

email.Send();
//Console.ReadKey();

//Patter: Singleton
SingletonBase singleton1 = ClassicSingletonLogger.GetInstance();
SingletonBase singleton2 = ClassicSingletonLogger.GetInstance();

if (singleton1 == singleton2)
{
    Console.WriteLine("ClassicSingletonLogger is a singleton");
}
Console.ReadKey();

//Patter: Prototype
Console.WriteLine("=========================================");

Teacher teacher = new("Sean", "Math");
Teacher teacherClone = (Teacher)teacher.Clone();
Console.WriteLine($"Teacher was cloned: {teacherClone.Name} who teaches: {teacherClone.Course}");

Student student = new("John", teacherClone);
Student studentClone = (Student)student.Clone();
Console.WriteLine($"Student was cloned: {studentClone.Name} who is taught by: {studentClone.Teacher.Name}");

teacherClone.Name = "Peter";
teacherClone.Course = "Science";
Console.WriteLine($"Student was cloned: {studentClone.Name} who is taught by: {studentClone.Teacher.Name}");
Console.ReadKey();

Console.WriteLine("=========================================");
// Make a clone of the coach
Coach coach = new Coach("Pep Guardiola", "Soccer", "Possesion");
Coach coachClone = (Coach)coach.Clone();
Console.WriteLine($"{coachClone.Sport} Coach was cloned: {coachClone.Name} with coaching style '{coachClone.CoachingStyle}'");

// Make a clone of the player
Player player = new Player("Julian Alvarez", "Soccer", "Forward", coachClone);
Player playerClone = (Player)player.Clone();
Console.WriteLine($"{playerClone.Sport} Player was cloned: {playerClone.Name} playing for {playerClone.Coach.Name} in the '{playerClone.Position}' position");

// Change the details of the coach
coachClone.Name = "Jurgen Klopp";
coachClone.CoachingStyle = "Counter-Pressing";

// Print out player clone details again
Console.WriteLine($"{playerClone.Sport} Player was cloned: {playerClone.Name} playing for {playerClone.Coach.Name} in the '{playerClone.Position}' position");
Console.ReadKey();
