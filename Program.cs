namespace optimizely_property_lists;

public class Program
{
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureCmsDefaults()
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
}
