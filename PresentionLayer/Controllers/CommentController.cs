using BusinessLayer.Concrate;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentionLayer.Controllers
{
	public class CommentController : Controller
	{
		CommentService cm = new CommentService(new CommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult PartialBlogComments()
		{
			return PartialView();
		}
	}
}
