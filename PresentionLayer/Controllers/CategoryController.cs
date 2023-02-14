using BusinessLayer.Concrate;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentionLayer.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService cm = new CategoryService(new CategoryRepository());
        public IActionResult Index()
        {
            var Categories = cm.GettAllCategories();
            return View(Categories);
        }
    }
}
