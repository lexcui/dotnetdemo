using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDemo.Async
{
    public class AsyncDemo : Demo
    {

        protected override void Execute()
        {
            ExecuteAsync();
        }

        private async void ExecuteAsync()
        {
            await createMultiTasksAsync();
            Console.WriteLine("Download completed.");
        }

        private async Task createMultiTasksAsync()
        {
            try
            {
                HttpClient client = new HttpClient() { MaxResponseContentBufferSize = 1000000 };

                Task<int> download1 =
                    DownloadURLAsync("https://github.com", client);
                Task<int> download2 =
                    DownloadURLAsync("https://cn.bing.com", client);

                

                var anyTaskDone = await Task.WhenAny(download1, download2);

                Console.WriteLine("First downloaded URL length is {0}",anyTaskDone.Result);
                


                int[] lengths = await Task.WhenAll(download1, download2);
                int total = lengths.Sum();

                Console.WriteLine("Total bytes returned:  {0}", total);
            }
            catch (Exception e)
            {
                Console.WriteLine("exception:  {0}", e);
            }


        }

        private async Task<int> DownloadURLAsync(string url, HttpClient client)
        {
            var byteArray = await client.GetByteArrayAsync(url);
            DisplayResults(url, byteArray);
            return byteArray.Length;
        }

        private void DisplayResults(string url, byte[] content)
        {
            var bytes = content.Length;
            var displayURL = url.Replace("http://", "");
            //Console.WriteLine(Encoding.UTF8.GetString(content));
            Console.WriteLine("{0,-30} {1,8}", displayURL, bytes);
        }


    }
}
