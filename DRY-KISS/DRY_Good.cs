// ✅ Good Example: Extract common logic into reusable method
public class OrderProcessorGood
{
    public void ProcessOrder()
    {
        ValidateOrder();
        CalculateTotal();
        SaveOrder();
    }

    private void ValidateOrder()
    {
        Console.WriteLine("Validate order");
    }

    private void CalculateTotal()
    {
        Console.WriteLine("Calculate total");
    }

    private void SaveOrder()
    {
        Console.WriteLine("Save order");
    }
}
