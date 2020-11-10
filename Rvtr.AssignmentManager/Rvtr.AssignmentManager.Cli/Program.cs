using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Hosting;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Rvtr.AssignmentManager.Cli
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            CommandLineBuilder commandLineBuilder = CreateCommandLineBuilder();
            Parser parser = commandLineBuilder.Build();
            return await parser.InvokeAsync(args);
        }

        public static CommandLineBuilder CreateCommandLineBuilder()
        {
            var root = new RootCommand(@"$ dotnet run --name 'Joe'")
            {
                new Option<string>("--name")
                {
                    IsRequired = true
                }
            };
            root.Handler = CommandHandler.Create<IHost>(RunAsync);
            return new CommandLineBuilder(root)
                .UseHost(CreateHostBuilder)
                .UseDefaults();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(ConfigureHostServices);
        }

        public static void ConfigureHostServices(HostBuilderContext hostContext, IServiceCollection services)
        {
        }

        public static async Task<int> RunAsync(IHost host)
        {
            await Task.Yield();
            IServiceProvider serviceProvider = host.Services;
            // var greeter = serviceProvider.GetRequiredService<IGreeter>();
            ILoggerFactory loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
            ILogger logger = loggerFactory.CreateLogger(typeof(Program));

            logger.LogInformation("Running");
            // greeter.Greet(name);
            return 0;
        }
    }
}
