namespace creational.patterns.FactoryMethodPattern;

public class CreditCardPayment : IPaymnet
{
    public void Pay(Double amount)
    {
        Console.WriteLine($"Paying {amount} using Credit Card");
    }
}
