using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.ViewModel
{
    public class ModelsCombined
    {
        public IEnumerable<Comment> IEnumerableComment { get; set; }
        public Comment Comment { get; set; }
    }
}
