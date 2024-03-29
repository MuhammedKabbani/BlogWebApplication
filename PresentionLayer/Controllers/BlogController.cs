﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentionLayer.Controllers
{
	public class BlogController : Controller
	{
		BlogService bs = new BlogService(new BlogRepository());
		public IActionResult Index()
		{
			var values = bs.GetAllBlogsWithCategories();
			return View(values);

		}
		public IActionResult Details(int id)
		{ 
			return View(bs.GetBlogById(id));
		}
	}
}
