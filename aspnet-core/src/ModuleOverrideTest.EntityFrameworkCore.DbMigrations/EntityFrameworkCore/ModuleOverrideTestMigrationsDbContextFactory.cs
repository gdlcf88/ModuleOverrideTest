using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ModuleOverrideTest.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ModuleOverrideTestMigrationsDbContextFactory : IDesignTimeDbContextFactory<ModuleOverrideTestMigrationsDbContext>
    {
        public ModuleOverrideTestMigrationsDbContext CreateDbContext(string[] args)
        {
            ModuleOverrideTestEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ModuleOverrideTestMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ModuleOverrideTestMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
