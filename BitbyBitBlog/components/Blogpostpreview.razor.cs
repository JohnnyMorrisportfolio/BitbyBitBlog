using Microsoft.AspNetCore.Components;
using BitbyBitBlog.Services.BlogPostDataService;

namespace BitbyBitBlog.components
{
    public partial class Blogpostpreview
    {
        [Parameter]
        public string ImageFilePath { get; set; } = "../Images/Johnny Port.jpg";
        [Parameter]
        public  string Blogpostpreviewtext { get; set; } = "default preview text";

        [Parameter]
        public string Title { get; set; } = "default title";

        [Parameter]
        public int Id { get; set; } = 0;


    }
}
