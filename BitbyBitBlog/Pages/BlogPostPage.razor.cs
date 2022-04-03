using BitbyBitBlog.Models;
using BitbyBitBlog.Services.BlogPostDataService;
using Microsoft.AspNetCore.Components;
using System.IO;

namespace BitbyBitBlog.Pages
{
    public partial class BlogPostPage
    {
        [Parameter]
        public int Id { get; set; }

        public BlogPost BlogPost { get; set; }

        protected override void OnInitialized()
        {
            var contentFiles = Directory.EnumerateFiles("Content/");

            foreach (var path in contentFiles)
            {
                var post = new BlogPostDataService(path).Read();
                
                if (post.Id == Id)
                {

                    BlogPost = post;

                }

            }
        }


    }
}
