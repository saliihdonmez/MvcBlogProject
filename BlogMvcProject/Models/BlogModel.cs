using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcProject.Models
{
    public class BlogModel
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }      
        public DateTime AddTime { get; set; }
        public bool Confirm { get; set; }
        public bool Homepage { get; set; }
    }
}