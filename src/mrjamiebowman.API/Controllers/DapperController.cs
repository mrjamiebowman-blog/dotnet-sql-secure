using Microsoft.AspNetCore.Mvc;
using mrjamiebowman.SQL.Domain.Interfaces;

namespace mrjamiebowman.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DapperController : ControllerBase
{
    // logger
    private readonly ILogger<DapperController> _logger; 
    private readonly IDataService _dataService; 

    public DapperController(ILogger<DapperController> logger, IDataService dataService)
    {
        _logger = logger;
        _dataService = dataService;
    }

    [HttpGet]
    public string Index()
    {
        return "Dapper";
    }
}
