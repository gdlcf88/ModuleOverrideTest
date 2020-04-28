using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace ModuleOverrideTest.EntityFrameworkCore
{
    public static class ModuleOverrideTestDbContextModelCreatingExtensions
    {
        public static void ConfigureModuleOverrideTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ModuleOverrideTestConsts.DbTablePrefix + "YourEntities", ModuleOverrideTestConsts.DbSchema);

            //    //...
            //});
        }
    }
}