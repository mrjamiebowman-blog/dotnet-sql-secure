using mrjamiebowman.SQL.Data;
using mrjamiebowman.SQL.Data.Repositories;
using mrjamiebowman.SQL.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// inject: data service
builder.Services.AddTransient<IDataService, DataService>();

// inject: repositories
builder.Services.AddKeyedTransient<ICustomerRepository, CustomerEntityFrameworkRepository>("ef");
builder.Services.AddKeyedTransient<ICustomerRepository, CustomerDapperRepository>("dapper");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Enable Swagger middleware
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

try
{
    app.Run();
} catch (Exception ex) {
    throw;
}

