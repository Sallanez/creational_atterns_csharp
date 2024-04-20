namespace creational.patterns.FactoryMethodPattern;
public class PayPalPayment : IPaymnet
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using PayPal");
    }
}
