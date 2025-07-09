// ❌ Code Smell: God Class 
public class OrderManager_Bad
{
    public void ProcessOrder()
    {
        Console.WriteLine("Validate order");
        Console.WriteLine("Calculate price");
        Console.WriteLine("Update inventory");
        Console.WriteLine("Send invoice");
        Console.WriteLine("Log order");
    }
}
