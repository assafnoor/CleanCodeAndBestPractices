// ❌ Code Smell: Long Method 
public class ReportGenerator_Bad
{
    public void GenerateReport()
    {
        Console.WriteLine("Start Report Generation");
        Console.WriteLine("Load data from database");
        // Simulate long process
        Console.WriteLine("Process data...");
        Console.WriteLine("Generate PDF");
        Console.WriteLine("Send report via email");
        Console.WriteLine("Log completion");
    }
}
