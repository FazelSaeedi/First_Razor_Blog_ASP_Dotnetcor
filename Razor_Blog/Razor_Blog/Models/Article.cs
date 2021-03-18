using System;


namespace Razor_Blog.Models
{
    public class Article
    {
        public Article(string title, string picture, string pictureAlt, string pictureTitle, string shortdescription, string body )
        {
            Title = title;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Shortdescription = shortdescription;
            Body = body;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }

        public int Id  { get; set; }

        public string Title  { get; set; }

        public string Picture  { get; set; }

        public string PictureAlt  { get; set; }

        public string PictureTitle  { get; set; }

        public string Shortdescription  { get; set; }

        public string Body   { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }
         

    }
}
