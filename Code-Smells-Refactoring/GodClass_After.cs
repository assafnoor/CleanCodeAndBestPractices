// ✅ Refactored: 
public class OrderValidator
{
    public void Validate() => Console.WriteLine("Validate order");
}

public class PriceCalculator
{
    public void Calculate() => Console.WriteLine("Calculate price");
}

public class InventoryUpdater
{
    public void Update() => Console.WriteLine("Update inventory");
}

public class InvoiceSender
{
    public void Send() => Console.WriteLine("Send invoice");
}

public class OrderLogger
{
    public void Log() => Console.WriteLine("Log order");
}

public class OrderProcessor
{
    private readonly OrderValidator _validator = new();
    private readonly PriceCalculator _calculator = new();
    private readonly InventoryUpdater _inventoryUpdater = new();
    private readonly InvoiceSender _invoiceSender = new();
    private readonly OrderLogger _logger = new();

    public void Process()
    {
        _validator.Validate();
        _calculator.Calculate();
        _inventoryUpdater.Update();
        _invoiceSender.Send();
        _logger.Log();
    }
}
