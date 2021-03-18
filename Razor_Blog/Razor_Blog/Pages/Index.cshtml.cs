﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Razor_Blog.Models;

namespace Razor_Blog.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleViwModel> Articles { get; set; }
        public readonly BlogContext _Context;

        public IndexModel(BlogContext context)
        {
            _Context = context;
        }

        public void OnGet()
        {
            Articles = _Context.Articles
                .Where(x => x.IsDeleted == false)
                .Select(x => new ArticleViwModel
            {
                Id = x.Id ,
                Title = x.Title ,
                Picture = x.Picture ,
                PictureAlt = x.PictureTitle ,
                PictureTitle = x.PictureAlt ,
                Shortdescription = x.Shortdescription ,

            }).ToList();

            //ViewData["message"] = "hellow World!";
        }

        public IActionResult OnGetDelete(int id)
        {
            var article = _Context.Articles.First(x => x.Id == id);
            article.IsDeleted = true;
            _Context.SaveChanges();

            return RedirectToPage("./Index");
        }

        /*public void OnPost(IFormCollection form)
        {

        }

        public IActionResult OnGetLoad()
        {
            return Page();
        }*/
    }
}
