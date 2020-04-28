using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ModuleOverrideTest.Data;
using Volo.Abp.DependencyInjection;

namespace ModuleOverrideTest.EntityFrameworkCore
{
    public class EntityFrameworkCoreModuleOverrideTestDbSchemaMigrator
        : IModuleOverrideTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreModuleOverrideTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ModuleOverrideTestMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ModuleOverrideTestMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}