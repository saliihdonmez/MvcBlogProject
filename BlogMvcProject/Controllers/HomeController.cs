using BlogMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcProject.Controllers
{
    public class HomeController : Controller
    {


        private BlogContext context = new BlogContext();
                     
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                               .Select(i => new BlogModel()
                               {
                                   Id = i.Id,
                                   Title = i.Title.Length > 100 ? i.Title.Substring(0, 100) + "..." : i.Title,
                                   Description=i.Description,
                                   AddTime=i.AddTime,
                                   Homepage=i.Homepage,
                                   Confirm=i.Confirm,
                                   PhotoPath=i.PhotoPath
                               })
                               .Where(i => i.Confirm == true && i.Homepage == true);

            return View(blogs.ToList());
        }
    }
}