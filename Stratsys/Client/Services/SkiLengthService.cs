using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client.Services
{
    public class SkiLengthService : ISkiLengthService
    {
        private HttpClient client;

        public SkiLengthService(IHttpClientFactory httpClientFactory)
        {
            client = httpClientFactory.CreateClient("StratsysSkiApi");
        }

        public async Task<string> Fetch(Skiier skiier)
        {
            var httpResponse = await client.GetAsync($"api/ski/getskilength?length={skiier.Length}&age={skiier.Age}&style={skiier.Style}");
            return await httpResponse.Content.ReadAsStringAsync();
        }
    }
}
