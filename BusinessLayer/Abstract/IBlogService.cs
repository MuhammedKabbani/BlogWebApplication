using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		public void BlogAdd(Blog b);
		public void BlogRemove(Blog b);
		public void BlogUpdate(Blog b);
		public Blog GetBlogById(int id);
		public List<Blog> GetAllBlogs();
	}
}
