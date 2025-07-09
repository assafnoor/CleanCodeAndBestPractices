// ❌ Bad Example: One class with too many responsibilities
public class Invoice
{
    public void CalculateTotal() 
    {
        Console.WriteLine("Calculating total...");
    }

    public void SaveToDatabase() 
    {
        Console.WriteLine("Saving to database...");
    }

    public void PrintInvoice() 
    {
        Console.WriteLine("Printing invoice...");
    }
}
// ✅ Good Example: Each class has a single responsibility

public class InvoiceCalculator
{
    public void CalculateTotal() 
    {
        Console.WriteLine("Calculating total...");
    }
}

public class InvoiceRepository
{
    public void SaveToDatabase() 
    {
        Console.WriteLine("Saving to database...");
    }
}

public class InvoicePrinter
{
    public void PrintInvoice() 
    {
        Console.WriteLine("Printing invoice...");
    }
}
