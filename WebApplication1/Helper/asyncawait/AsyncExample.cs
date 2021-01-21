using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApplication1.Helper.asyncawait
{
    //Async and await = used to make responsive programs
    // web, db, file use async use async
    public class AsyncExample
    {
        String url = "http://msdn.microsoft.com";

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);
            using (var streamWriter = new StreamWriter
                (@"D:\learn\core-src\mvc-src\WebApplication1\output\result.html")) 
            {
                await streamWriter.WriteAsync(html);
            }
        }
        public void Example()
        {           
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var streamWriter = new StreamWriter(@"D:\learn\core-src\mvc-src\WebApplication1\output\result.html"))
            {
                streamWriter.Write(html);
            }

        
        }
    }
}
