﻿using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BitbyBitBlog.Models;
using BitbyBitBlog.Services.BlogPostDataService;
using Microsoft.AspNetCore.Components;

namespace BitbyBitBlog.components
{
    public partial class LatestBlogPostPreview
    {
        public BlogPostPreviewModel Preview { get; set; } = new();
        public BlogPost Blog { get; set; } = new();

        [Inject]
        private BlogPostDataService _blogService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await _blogService.Initialize();
            var latestBlog = _blogService.BlogsToRead.blogs.Last();

            Blog = await _blogService.ReadAsync(latestBlog);
            Preview = Blog.BlogPostPreview;
        }
    }
}