using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Models;

namespace Razor_Blog.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly BlogContext _context;

        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public void OnPost(CreateArticle model)
        {
            var article = new Article(model.title, model.picture, model.pictureAlt, model.pictureTitle,
                model.shortDescription, model.body);
            _context.Articles.Add(article);
            _context.SaveChanges();

            TempData["success"] = "مقاله با موفقیت ذخیره شد";
        }
    }
}
