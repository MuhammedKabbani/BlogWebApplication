using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public Blog GetBlogById(int id)
		{
			return _repo.Get(id);
		}
	}
}
