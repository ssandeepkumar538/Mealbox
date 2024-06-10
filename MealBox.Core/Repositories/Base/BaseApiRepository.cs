using System;
using System.Net;
using System.Net.Http.Headers;
using System.Threading;
using Newtonsoft.Json;

namespace MealBox.Core.Repositories.Base
{
    public class BaseApiRepository
    {
        private readonly HttpClient _httpClient;

        public BaseApiRepository()
        {
            _httpClient = new HttpClient();
        }

        protected async Task<TResponse?> GetAsync<TResponse>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            return await HandleResponseAsync<TResponse>(response);
        }

        private async Task<T?> HandleResponseAsync<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    // Return null or handle as appropriate for your use case
                    return JsonConvert.DeserializeObject<T>("true");
                }

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content);
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {

                return JsonConvert.DeserializeObject<T>("false");
            }
            return default;
        }
    }
}

