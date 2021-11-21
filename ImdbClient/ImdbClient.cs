using ImdbClient.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ImdbClient
{
    internal class ImdbClient : IImdbClient
    {
        private readonly RestClient restClient;
        private readonly string _apiKey;
        private readonly string _lang;

        public ImdbClient(string baseUrl, string apiKey, string lang)
        {
            restClient = new RestClient(baseUrl);

            _apiKey = apiKey;
            _lang = lang; 
        }

        public async Task<SearchData> SearchAsync(string expression, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(expression))
                throw new ArgumentNullException(nameof(expression));

            var request = new RestRequest($"API/Search/{_apiKey}/{expression}", DataFormat.Json);

            var response = await restClient.ExecuteGetAsync(request, cancellationToken);

            var result = JsonConvert.DeserializeObject<SearchData>(response.Content);

            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new ImdbException(result.ErrorMessage);

            return result;
        }

        public async Task<PosterData> PostersAsync(string id, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            var request = new RestRequest($"API/Posters/{_apiKey}/{id}", DataFormat.Json);

            var response = await restClient.ExecuteGetAsync(request, cancellationToken);

            var result = JsonConvert.DeserializeObject<PosterData>(response.Content);

            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new ImdbException(result.ErrorMessage);

            return result;
        }

        public async Task<TitleData> TitleAsync(string id, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            var request = new RestRequest($"{_lang}/API/Title/{_apiKey}/{id}", DataFormat.Json);

            var response = await restClient.ExecuteGetAsync(request, cancellationToken);

            var result = JsonConvert.DeserializeObject<TitleData>(response.Content);

            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new ImdbException(result.ErrorMessage);

            return result;
        }

        public async Task<WikipediaData> WikipediaAsync(string id, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            var request = new RestRequest($"{_lang}/API/Wikipedia/{_apiKey}/{id}", DataFormat.Json);

            var response = await restClient.ExecuteGetAsync(request, cancellationToken);

            var result = JsonConvert.DeserializeObject<WikipediaData>(response.Content);

            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new ImdbException(result.ErrorMessage);

            return result;
        }
    }
}
