namespace creational.patterns.AbstraactFactoryPattern.Interfaces;

public interface IInternationalFactory
{
    ILenguage CreateLenguage();
    ICapitalCity CreateCapitalCity();
}
