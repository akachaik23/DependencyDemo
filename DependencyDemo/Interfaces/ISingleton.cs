namespace DependencyDemo.Interfaces;

public interface ISingleton
{

}

public class Singleton : ISingleton, IDisposable
{
    public Singleton()
    {
        Console.WriteLine("Singleton Constructure");
    }

    public void Dispose()
    {
        Console.WriteLine("Singleton Dispose");
    }
}

public interface IScoped
{

}

public class Scoped : IScoped, IDisposable
{
    public Scoped()
    {
        Console.WriteLine("Scoped Constructure");
    }

    public void Dispose()
    {
        Console.WriteLine("Scoped Dispose");
    }
}

public interface ITransient
{

}

public class Transient : ITransient, IDisposable
{
    public Transient()
    {
        Console.WriteLine("Transient Constructure");
    }

    public void Dispose()
    {
        Console.WriteLine("Transient Dispose");
    }
}
