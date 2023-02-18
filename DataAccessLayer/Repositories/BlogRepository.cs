using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
	public class BlogRepository : Repository<Blog>, IBlogRepository
	{
		public List<Blog> GetBlogsWithCategories()
		{
			using (Context c = new Context())
			{
				return c.Blogs.Include(x=>x.Category).ToList();

			}
		}
	}
}
