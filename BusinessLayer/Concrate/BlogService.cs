using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System.Linq.Expressions;

namespace BusinessLayer.Concrate
{
	public class BlogService : IBlogService
	{
		IBlogRepository _repo;
		public BlogService(IBlogRepository repo)
		{
			_repo = repo;
		}
		public void BlogAdd(Blog b)
		{
			_repo.Add(b);
			
		}

		public void BlogRemove(Blog b)
		{
			_repo.Delete(b);
		}

		public void BlogUpdate(Blog b)
		{
			_repo.Update(b);
		}

		public List<Blog> GetAllBlogs()
		{
			return _repo.GetAll();
		}
		public List<Blog> GetAllBlogs(Expression<Func<Blog,bool>> expression)
		{
			return _repo.GetAll(expression);
		}

		public List<Blog> GetAllBlogsWithCategories()
		{
			return _repo.GetBlogsWithCategories();
		}

		public Blog GetBlogById(int id)
		{
			return _repo.Get(id);
		}
	}
}
