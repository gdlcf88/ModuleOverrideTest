using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ModuleOverrideTest.Data
{
    /* This is used if database provider does't define
     * IModuleOverrideTestDbSchemaMigrator implementation.
     */
    public class NullModuleOverrideTestDbSchemaMigrator : IModuleOverrideTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}