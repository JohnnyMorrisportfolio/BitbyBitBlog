using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;


namespace BitbyBitBlog.Services.FileService
{ 

    public class FileService
    { 
        [Inject]
        private HttpClient _client { get; set; }
        public FileService(HttpClient client)
        {
            _client = client ?? throw new ArgumentException(nameof(client));
        }
        public async Task SaveAsAsync(IJSRuntime js, string filePath)
        {
            var bytes = await _client.GetByteArrayAsync(filePath);
            await js.InvokeAsync<object>("saveAsFile",Path.GetFileName(filePath), Convert.ToBase64String(bytes));
        }
    }

}