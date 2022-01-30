using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class AccessTokenScopeAttribute : AuthorizeAttribute
{
    public HashSet<string> Scopes { get; set; }

    public AccessTokenScopeAttribute(string scope) : base()
        => Scopes = new HashSet<string> {scope};
}

[ApiController]

[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [Authorize("")]
    [HttpPost("api2")]
    public void Api2()
    {
    }
}