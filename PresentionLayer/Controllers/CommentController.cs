using Microsoft.AspNetCore.Mvc;

namespace PresentionLayer.Controllers
{
	public class CommentController : Controller
	{
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
