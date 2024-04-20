namespace creational.patterns.FactoryMethodPattern;

public class PaymentFactory
{
    public static IPaymnet Create(PaymentMethod paymentMethod)
    {
        return paymentMethod switch
        {
            PaymentMethod.CreditCard => new CreditCardPayment(),
            PaymentMethod.GooglePay => new GooglePayPayment(),
            PaymentMethod.PayPal => new PayPalPayment(),
            _ => throw new NotSupportedException("Invalid payment method")
        };
    }
}
