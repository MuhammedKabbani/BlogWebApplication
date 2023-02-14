using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentionLayer.Controllers
{
	public class BlogController : Controller
	{
		BlogService bs = new BlogService(new BlogRepository());
		public IActionResult Index()
		{
			var values = bs.GetAllBlogs();
			return View(values);
		}
	}
}
