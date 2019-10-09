using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Nexus.Link.Services.Implementations.BusinessApi.Startup;
using System;

namespace AcmeCorp.BusinessApi.Service
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public class Program
  {
    public static void Main(string[] args)
    {
      try
      {
        System.Diagnostics.Debug.WriteLine($"Entered: {typeof(Program).FullName} {nameof(Main)}");
        CreateWebHostBuilder(args).Build().Run();
      }
      catch (Exception e)
      {
        System.Diagnostics.Trace.WriteLine($"Unexpected error: {typeof(Program).FullName} {nameof(Main)} {e}");
      }
      finally
      {
        System.Diagnostics.Trace.WriteLine($"Unexpected exit: {typeof(Program).FullName} {nameof(Main)}");
      }
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(BusinessApiProgramHelper.AddConfiguration)
            .UseStartup<Startup>();
  }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
