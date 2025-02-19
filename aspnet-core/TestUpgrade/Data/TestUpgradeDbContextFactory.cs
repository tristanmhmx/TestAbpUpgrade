using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestUpgrade.Data;

public class TestUpgradeDbContextFactory : IDesignTimeDbContextFactory<TestUpgradeDbContext>
{
    public TestUpgradeDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TestUpgradeDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TestUpgradeDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
