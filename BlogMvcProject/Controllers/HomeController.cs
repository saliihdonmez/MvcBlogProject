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
            return View(context.Blogs.ToList());
        }
    }
}