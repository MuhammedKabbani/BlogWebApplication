using BusinessLayer.Concrate;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentionLayer.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryService cm = new CategoryService(new CategoryRepository());

        public IViewComponentResult Invoke()
        {
            var categories = cm.GettAllCategories();
            return View(categories);
        }
    }
}
