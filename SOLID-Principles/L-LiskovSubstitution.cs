// L-LiskovSubstitution.cs

// ❌ Bad Example: Subclass breaks the behavior of the base class
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying...");
    }
}


// ✅ Good Example: Respect substitution by separating behaviors
public interface IFlyable
{
    void Fly();
}

public class Eagle : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Eagle is flying...");
    }
}

public class Ostrich
{
    public void Walk()
    {
        Console.WriteLine("Ostrich is walking...");
    }
}