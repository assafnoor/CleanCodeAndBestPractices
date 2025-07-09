// ✅ Good Example: Simple and clear using polymorphism
public interface IPaymentProcessor
{
    void ProcessPayment();
}

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Credit Card payment...");
    }
}

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal payment...");
    }
}
