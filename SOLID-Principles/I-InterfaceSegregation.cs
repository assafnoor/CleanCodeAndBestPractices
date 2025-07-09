// I-InterfaceSegregation.cs

// ❌ Bad Example: Interface forces implementation of unused methods
public interface IWorker
{
    void Work();
    void Eat();
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot working...");
    }

    public void Eat()
    {
        throw new NotImplementedException("Robot doesn't eat");
    }
}

// ✅ Good Example: Split interfaces based on responsibility
public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class Human : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Human working...");
    }

    public void Eat()
    {
        Console.WriteLine("Human eating...");
    }
}

public class UpdatedRobot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot working...");
    }
}