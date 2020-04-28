using System.Threading.Tasks;

namespace ModuleOverrideTest.Data
{
    public interface IModuleOverrideTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
