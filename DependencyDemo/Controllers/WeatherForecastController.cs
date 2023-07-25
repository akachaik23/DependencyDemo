using DependencyDemo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class SingletonController : ControllerBase
{
    private readonly ISingleton _singleton1;
    private readonly ISingleton _singleton2;

    public SingletonController(ISingleton singleton1, ISingleton singleton2)
    {
        _singleton1 = singleton1;
        _singleton2 = singleton2;
    }

    [HttpGet(Name = "GetWeatherForecastSingleton")]
    public IActionResult Get()
    {
        var result = new
        {
            Singleton1 = _singleton1.GetHashCode(),
            Singleton2 = _singleton2.GetHashCode()
        };

        return Ok(result);
    }
}

[ApiController]
[Route("[controller]")]
public class ScopedController : ControllerBase
{
    private readonly IScoped _scope1;
    private readonly IScoped _scope2;

    public ScopedController(IScoped scope1, IScoped scope2)
    {
        _scope1 = scope1;
        _scope2 = scope2;
    }

    [HttpGet(Name = "GetWeatherForecastScope")]
    public IActionResult Get()
    {
        var result = new
        {
            Scope1 = _scope1.GetHashCode(),
            Scope2 = _scope2.GetHashCode()
        };

        return Ok(result);
    }
}

[ApiController]
[Route("[controller]")]
public class TransientController : ControllerBase
{
    private readonly ITransient _transient1;
    private readonly ITransient _transient2;

    public TransientController(ITransient transient1, ITransient transient2)
    {
        _transient1 = transient1;
        _transient2 = transient2;
    }

    [HttpGet(Name = "GetWeatherForecastTransient")]
    public IActionResult Get()
    {
        var result = new
        {
            Transient1 = _transient1.GetHashCode(),
            Transient2 = _transient2.GetHashCode()
        };

        return Ok(result);
    }
}