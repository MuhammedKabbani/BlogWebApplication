using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class CommentService : ICommentService
	{
		ICommentRepository _commentRepository;
		public CommentService(ICommentRepository commentRepository)
		{
			_commentRepository = commentRepository;
		}
		public void AddComment(Comment c)
		{
			_commentRepository.Add(c);
		}

		public void DeleteComment(Comment c)
		{
			_commentRepository.Delete(c);
		}

		public Comment GetCommentById(int id)
		{
			return _commentRepository.Get(id);
		}

		public List<Comment> GettAllComments(int blogId)
		{

			return _commentRepository.GetAll(x=>x.BlogId == blogId);
		}

		public void UpdateComment(Comment c)
		{
			_commentRepository.Update(c);
		}
	}
}