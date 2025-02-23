using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog
builder.Host.UseSerilog((context, config) =>
{
    config.WriteTo.Console()
          .WriteTo.MSSqlServer(
              connectionString: context.Configuration.GetConnectionString("DefaultConnection"),
              sinkOptions: new Serilog.Sinks.MSSqlServer.MSSqlServerSinkOptions { TableName = "Logs" });
});

builder.Services.AddControllers();
var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

app.Run();
