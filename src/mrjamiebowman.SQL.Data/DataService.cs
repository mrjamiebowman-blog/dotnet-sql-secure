using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using mrjamiebowman.SQL.Domain.Interfaces;

namespace mrjamiebowman.SQL.Data;

public class DataService : IDataService
{
    // logger
    private ILogger<DataService> _logger;

    // repositories
    private readonly ICustomerRepository _efCustomerRepository;
    private readonly ICustomerRepository _dapperCustomerRepository;

    public DataService([FromKeyedServices("ef")] ICustomerRepository efCustomerRepository, [FromKeyedServices("dapper")] ICustomerRepository dapperCustomerRepository)
    {
        _efCustomerRepository = efCustomerRepository;
        _dapperCustomerRepository = dapperCustomerRepository;
    }
}
