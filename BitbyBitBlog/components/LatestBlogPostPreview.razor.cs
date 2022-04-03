using System.IO;
using System.Linq;
using BitbyBitBlog.Models;
using BitbyBitBlog.Services.BlogPostDataService;

namespace BitbyBitBlog.components
{
    public partial class LatestBlogPostPreview
    {
        private BlogPostPreviewModel preview;
        private BlogPost blog;

        protected override void OnInitialized()
        {
            var directory = new DirectoryInfo("Content/");
            var latestFile = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
            
            blog= new BlogPostDataService(latestFile.FullName).Read();

            preview = blog.BlogPostPreview;
            
        }
    }
}
