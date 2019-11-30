using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcProject.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName="C#"},
                new Category(){CategoryName="Asp.net MVC"},
                new Category(){CategoryName="Asp.net WebForm"},
                new Category(){CategoryName="Windows Form"}
               
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();


            List<Blog> blogs = new List<Blog>()
            {
                new Blog(){ Title="C# about array",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-10),Homepage=true,Confirm=true,Content="C# about Delegates C# about Delegates C# about Delegates C# about Delegates",PhotoPath="1.jpg",CategoryId=1},
                new Blog(){ Title="C# about enum",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-30),Homepage=false,Confirm=true,Content="C# about Delegates C# about Generic C# about Delegates C# about Delegates",PhotoPath="1.jpg",CategoryId=1},
                new Blog(){ Title="C# about class",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-20),Homepage=true,Confirm=true,Content="C# about Delegates C# about Delegates C# about Delegates C# about Delegates",PhotoPath="2.jpg",CategoryId=2},
                new Blog(){ Title="C# about interface",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-5),Homepage=false,Confirm=true,Content="C# about Delegates C# about Delegates C# about Delegates C# about Delegates",PhotoPath="2.jpg",CategoryId=2},
                new Blog(){ Title="C# about solid",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-17),Homepage=true,Confirm=true,Content="C# about Delegates C# about Delegates C# about Delegates C# about Delegates",PhotoPath="2.jpg",CategoryId=3},
                 new Blog(){ Title="C# about mvc",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-10),Homepage=false,Confirm=false,Content="C# about Delegates C# about Delegates C# about Delegates C# about Delegates",PhotoPath="4.jpg",CategoryId=4},
                  new Blog(){ Title="C# about core",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-50),Homepage=true,Confirm=true,Content="C# about Delegates C# about Delegates C# about Delegates C# about Delegates",PhotoPath="4.jpg",CategoryId=4},
                   new Blog(){ Title="C# about design pattern",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-10),Homepage=true,Confirm=false,Content="C# about Delegates C# about Delegates C# about Delegates C# about Delegates",PhotoPath="4.jpg",CategoryId=4}
            };


            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}