using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.JSInterop;


namespace BitbyBitBlog.Services.FileService
{
    public static class FileService
    {
        public async static Task SaveAs(IJSRuntime js, string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            await js.InvokeAsync<object>(
                "saveAsFile",
                new FileInfo(filePath).Name,
                Convert.ToBase64String(bytes));
        }
    }

}