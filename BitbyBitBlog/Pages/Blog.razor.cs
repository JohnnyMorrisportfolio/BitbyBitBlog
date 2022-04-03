using BitbyBitBlog.components;
using BitbyBitBlog.Services.BlogPostDataService;
using System.Collections.Generic;
using System.IO;
using BitbyBitBlog.Models;

namespace BitbyBitBlog.Pages
{
    public partial class Blog
    {
        private List<BlogPost> blogpostpreviews = new List<BlogPost>();

        //read all files in Content folder
        protected override void OnInitialized()
        {
            var contentFiles = Directory.EnumerateFiles("Content/");

            foreach (var path in contentFiles)
            {
                blogpostpreviews.Add(new BlogPostDataService(path).Read());
            }
        }


    }
}
