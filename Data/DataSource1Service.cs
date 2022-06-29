using System.Net.Http.Json;

namespace IgApplication.DataSource1
{
    public class DataSource1Service
    {
        private readonly HttpClient http;

        public DataSource1Service(HttpClient http)
        {
            this.http = http;
        }

        public async Task<OReillyBooksType> GetOReillyBooks()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://oreillydemoapi.azurewebsites.net/api.rsc/OReillyBooks", UriKind.RelativeOrAbsolute));
            request.Headers.Add("x-cdata-authtoken", "<api_key>");
            using HttpResponseMessage response = await http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<OReillyBooksType>().ConfigureAwait(false);
            }

            return null;
        }
    }
}