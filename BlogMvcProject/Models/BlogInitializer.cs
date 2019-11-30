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
                new Blog(){ Title="Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan de Finibus Bonorum et Malorum (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan Lorem ipsum dolor sit amet 1.10.32 sayılı bölümdeki bir satırdan gelmektedirlerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılanbölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.",Description="C# about Delegates",AddTime=DateTime.Now.AddDays(-10),Homepage=true,Confirm=true,Content="C# about Delegates C# about Delegates C# about Delegates C# about Delegates",PhotoPath="1.jpg",CategoryId=1},
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