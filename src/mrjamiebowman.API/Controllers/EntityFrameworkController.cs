using Microsoft.AspNetCore.Mvc;

namespace mrjamiebowman.API.Controllers;


[ApiController]
[Route("[controller]")]
public class EntityFrameworkController : ControllerBase
{
    [HttpGet]
    public string Index()
    {
        return "EntityFramework";
    }
}
