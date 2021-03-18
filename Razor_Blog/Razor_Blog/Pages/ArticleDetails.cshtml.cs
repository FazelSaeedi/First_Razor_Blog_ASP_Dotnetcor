using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Models;

namespace Razor_Blog.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViwModel Article { get; set; }

        private readonly BlogContext _context;

        public ArticleDetailsModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Article = _context.Articles.Select(x => new ArticleViwModel
            {
                Id = x.Id ,
                Title = x.Title ,
                Body = x.Body ,
                Picture = x.Picture ,
                PictureTitle = x.PictureTitle ,
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
