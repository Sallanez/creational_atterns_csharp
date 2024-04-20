namespace creational.patterns.FactoryMethodPattern;

public class GooglePayPayment : IPaymnet
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using Google Pay.");
    }
}
