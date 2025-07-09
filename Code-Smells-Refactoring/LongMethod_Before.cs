// ✅ Refactored:
public class ReportGenerator_Good
{
    public void GenerateReport()
    {
        Start();
        LoadData();
        ProcessData();
        GeneratePDF();
        SendEmail();
        LogCompletion();
    }

    private void Start() => Console.WriteLine("Start Report Generation");
    private void LoadData() => Console.WriteLine("Load data from database");
    private void ProcessData() => Console.WriteLine("Process data...");
    private void GeneratePDF() => Console.WriteLine("Generate PDF");
    private void SendEmail() => Console.WriteLine("Send report via email");
    private void LogCompletion() => Console.WriteLine("Log completion");
}
