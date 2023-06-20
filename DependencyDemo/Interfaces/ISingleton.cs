namespace DependencyDemo.Interfaces;

public interface ISingleton
{

}

public class Singleton : ISingleton, IDisposable
{
    public Singleton()
    {
        
    }

    public void Dispose()
    {

    }
}

public interface IScoped
{

}

public class Scoped : IScoped, IDisposable
{
    public Scoped()
    {
        
    }

    public void Dispose()
    {
        
    }
}

public interface ITransient
{

}

public class Transient : ITransient, IDisposable
{
    public Transient()
    {
        
    }

    public void Dispose()
    {

    }
}
