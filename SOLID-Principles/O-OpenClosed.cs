// O-OpenClosed.cs

// ❌ Bad Example: You must modify the class to add new discount types
public class DiscountCalculator
{
    public decimal GetDiscount(string customerType)
    {
        if (customerType == "Regular")
            return 5;
        else if (customerType == "VIP")
            return 10;

        return 0;
    }
}

// ✅ Good Example: Open for extension, closed for modification

public interface IDiscountStrategy
{
    decimal GetDiscount();
}

public class RegularCustomerDiscount : IDiscountStrategy
{
    public decimal GetDiscount() => 5;
}

public class VIPCustomerDiscount : IDiscountStrategy
{
    public decimal GetDiscount() => 10;
}

public class DiscountService
{
    private readonly IDiscountStrategy _strategy;

    public DiscountService(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal ApplyDiscount() => _strategy.GetDiscount();
}
