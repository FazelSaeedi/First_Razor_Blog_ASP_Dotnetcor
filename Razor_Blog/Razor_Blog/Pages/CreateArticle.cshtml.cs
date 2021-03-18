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

        [TempData]
        public string ErrorMessage { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }

        public CreateArticle Command { get; set; }

        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(CreateArticle Command)
        {
            if (ModelState.IsValid)
            {
                var article = new Article(Command.title, Command.picture, Command.pictureAlt, Command.pictureTitle,
                    Command.shortDescription, Command.body);

                _context.Articles.Add(article);
                _context.SaveChanges();

                SuccessMessage = "مقاله با موفقیت ذخیره شد";
                return RedirectToPage("./Index");
            }
            else
            {
                ErrorMessage = "مقاله با موفقیت ذخیره نشد";
                return Page();
            }

        }
    }
}
