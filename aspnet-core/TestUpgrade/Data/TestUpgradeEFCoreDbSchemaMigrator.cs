using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace TestUpgrade.Data;

public class TestUpgradeEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public TestUpgradeEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TestUpgradeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TestUpgradeDbContext>()
            .Database
            .MigrateAsync();
    }
}
