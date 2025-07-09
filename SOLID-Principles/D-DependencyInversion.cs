// D-DependencyInversion.cs

// ❌ Bad Example: High-level module depends on low-level module
public class MySqlDatabase
{
    public void SaveOrder(string orderData)
    {
        Console.WriteLine("Order saved to MySQL: " + orderData);
    }
}

public class OrderServiceBad
{
    private MySqlDatabase _database = new MySqlDatabase();

    public void ProcessOrder(string order)
    {
        // Logic...
        _database.SaveOrder(order);
    }
}

// ✅ Good Example: Depend on abstraction, not concrete implementation
public interface IDatabase
{
    void SaveOrder(string orderData);
}

public class SqlServerDatabase : IDatabase
{
    public void SaveOrder(string orderData)
    {
        Console.WriteLine("Order saved to SQL Server: " + orderData);
    }
}

public class OrderServiceGood
{
    private readonly IDatabase _database;

    public OrderServiceGood(IDatabase database)
    {
        _database = database;
    }

    public void ProcessOrder(string order)
    {
        // Logic...
        _database.SaveOrder(order);
    }
}