using EasyAbp.SharedResources.Categories;

namespace EasyAbp.SharedResources.Web.Pages.SharedResources.Categories.Category
{
    public class MyCreateModalModel : CreateModalModel
    {
        public MyCreateModalModel(ICategoryAppService service) : base(service)
        {
        }
    }
}