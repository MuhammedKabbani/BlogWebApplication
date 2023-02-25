using BusinessLayer.Concrate;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentionLayer.ViewComponents.Comment
{
	public class CommentsByBlog : ViewComponent
	{
		CommentService cm = new CommentService(new CommentRepository());
		public IViewComponentResult Invoke(int blogId)
		{
			var comments = cm.GettAllComments(blogId);
			return View(comments);
		}
	}
}
