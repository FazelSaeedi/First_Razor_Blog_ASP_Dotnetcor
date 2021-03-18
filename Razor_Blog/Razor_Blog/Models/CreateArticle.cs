using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_Blog.Models
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage = "عنوان مقاله اجباری است")]
        public string title { get; set; }

        [Required(ErrorMessage = "عکس مقاله اجباری است")]
        [DisplayName("عکس")]
        public string picture { get; set; }

        [Required(ErrorMessage = "عکسalt مقاله اجباری است")]
        [DisplayName("عکس alt")]
        public string pictureAlt{ get; set; }

        [DisplayName("عنوان عکس")]
        [Required(ErrorMessage = "عنوان عکس مقاله اجباری است ")]
        public string pictureTitle { get; set; }

        [DisplayName("توضیحات کوتاه ")]
        [Required(ErrorMessage = "توضیحات کوتاه مقاله اجباری است ")]
        public string shortDescription{ get; set; }

        [DisplayName("متن مقاله")]
        public string body{ get; set; }

    }
}
