using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		public void AddComment(Comment c);
		public void DeleteComment(Comment c);
		public void UpdateComment(Comment c);
		public Comment GetCommentById(int id);
		public List<Comment> GettAllComments(int blogId);
	}
}
