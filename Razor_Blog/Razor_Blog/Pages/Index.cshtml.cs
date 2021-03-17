using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Razor_Blog.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["message"] = "hellow World!";
        }

        public void OnPost(IFormCollection form)
        {

        }

        public IActionResult OnGetLoad()
        {
            return Page();
        }
    }
}
