// ❌ Bad Example: Duplicate code repeated multiple times
public class OrderProcessorBad
{
    public void ProcessOrder1()
    {
        Console.WriteLine("Validate order");
        Console.WriteLine("Calculate total");
        Console.WriteLine("Save order");
    }

    public void ProcessOrder2()
    {
        Console.WriteLine("Validate order");
        Console.WriteLine("Calculate total");
        Console.WriteLine("Save order");
    }
}
