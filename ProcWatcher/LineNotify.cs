using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProcWatcher
{
    public class LineNotifyResponse
    {
        public bool IsSuccessful { get; set; }
        public HttpStatusCode StatusCode {  get; set; }
        public string? ResponsePayload { get; set; }
    }

    public static class LineNotify
    {
        public static async Task<LineNotifyResponse> SendMessage(string message, string accessToken)
        {
            // Initialize HTTP client
            using (var client = new HttpClient())
            {
                // Assign fixed base address
                client.BaseAddress = new Uri("https://notify-api.line.me/");
                // Assign bearer token for target notification group or user
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                // Construct request message
                var content = new FormUrlEncodedContent(
                [
                    new KeyValuePair<string, string>("message", message)
                ]);
                // Send the request and wait for response
                var response = await client.PostAsync("api/notify", content);
                // Return response object
                return new LineNotifyResponse()
                {
                    IsSuccessful = response.IsSuccessStatusCode,
                    StatusCode = response.StatusCode,
                    ResponsePayload = await response.Content.ReadAsStringAsync(),
                };
            }
        }
    }
}
