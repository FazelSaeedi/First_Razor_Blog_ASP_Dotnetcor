using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_Blog.Models
{
    public class CreateArticle
    {

        public string title { get; set; }

        public string picture { get; set; }

        public string pictureAlt{ get; set; }

        public string pictureTitle { get; set; }

        public string shortDescription{ get; set; }

        public string body{ get; set; }

    }
}
