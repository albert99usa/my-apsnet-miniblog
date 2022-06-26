using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Article
    {
        public int Id { get; set; }
        public String Title { get; set; }
        [Display(Name = "Content")]
        public string BodyBrief { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string URL { get; set; }
    }
}
