using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SOLID Principles Demo ===\n");

        RunSingleResponsibility();
        RunOpenClosed();
        RunLiskovSubstitution();
        RunInterfaceSegregation();
        RunDependencyInversion();

        Console.WriteLine("\n=== End ===");

        Console.WriteLine("=== SOLID DRY-KISS Demo ===\n");

        RunDRY();
        RunKISS();
        
        Console.WriteLine("\n=== End ===");
    }

    static void RunSingleResponsibility()
    {
        Console.WriteLine("\n[S] Single Responsibility Principle");

        var calculator = new InvoiceCalculator();
        calculator.CalculateTotal();

        var repository = new InvoiceRepository();
        repository.SaveToDatabase();

        var printer = new InvoicePrinter();
        printer.PrintInvoice();
    }

    static void RunOpenClosed()
    {
        Console.WriteLine("\n[O] Open/Closed Principle");

        IDiscountStrategy vipDiscount = new VIPCustomerDiscount();
        var service = new DiscountService(vipDiscount);
        Console.WriteLine($"VIP Discount: {service.ApplyDiscount()}%");
    }

    static void RunLiskovSubstitution()
    {
        Console.WriteLine("\n[L] Liskov Substitution Principle");

        IFlyable eagle = new Eagle();
        eagle.Fly();

        var ostrich = new Ostrich();
        ostrich.Walk();
    }

    static void RunInterfaceSegregation()
    {
        Console.WriteLine("\n[I] Interface Segregation Principle");

        IWorkable robot = new UpdatedRobot();
        robot.Work();

        var human = new Human();
        human.Work();
        human.Eat();
    }

    static void RunDependencyInversion()
    {
        Console.WriteLine("\n[D] Dependency Inversion Principle");

        IDatabase db = new SqlServerDatabase();
        var orderService = new OrderServiceGood(db);
        orderService.ProcessOrder("Order#12345");
    }
    static void RunDRY()
    {
        Console.WriteLine("\n[DRY] Don't Repeat Yourself");

        var bad = new OrderProcessorBad();
        bad.ProcessOrder1();
        bad.ProcessOrder2();

        var good = new OrderProcessorGood();
        good.ProcessOrder();
    }

    static void RunKISS()
    {
        Console.WriteLine("\n[KISS] Keep It Simple, Stupid");

        var cc = new CreditCardPaymentProcessor();
        cc.ProcessPayment();

        var pp = new PayPalPaymentProcessor();
        pp.ProcessPayment();
    }
    static void RunCodeSmells()
    {
        Console.WriteLine("\n[Code Smells] Long Method - Before");
        new ReportGenerator_Bad().GenerateReport();

        Console.WriteLine("\n[Code Smells] Long Method - After");
        new ReportGenerator_Good().GenerateReport();

        Console.WriteLine("\n[Code Smells] God Class - Before");
        new OrderManager_Bad().ProcessOrder();

        Console.WriteLine("\n[Code Smells] God Class - After");
        var processor = new OrderProcessor();
        processor.Process();
    }

}
