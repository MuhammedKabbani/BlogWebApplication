using EntityLayer.Concrate;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		public void BlogAdd(Blog b);
		public void BlogRemove(Blog b);
		public void BlogUpdate(Blog b);
		public Blog GetBlogById(int id);
		public List<Blog> GetAllBlogs();
		public List<Blog> GetAllBlogsWithCategories();
	}
}
