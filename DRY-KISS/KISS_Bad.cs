// ❌ Bad Example: Overly complex method with unnecessary logic
public class PaymentProcessorBad
{
    public void ProcessPayment(int paymentType)
    {
        if(paymentType == 1)
        {
            // Complex logic with many nested ifs
            Console.WriteLine("Processing Credit Card payment...");
            // ... many other complex steps
        }
        else if(paymentType == 2)
        {
            Console.WriteLine("Processing PayPal payment...");
        }
        else
        {
            Console.WriteLine("Unknown payment type");
        }
    }
}
