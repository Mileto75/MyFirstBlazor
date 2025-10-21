using MyFirstBlazor.Components.Models;
using System.Text.Json;

namespace MyFirstBlazor.Components.UI
{
    public partial class Quote
    {
        private HttpClient httpClient;
        private QuoteModel quoteModel;
        public Quote()
        {
            httpClient = new();    
        }
        protected async override Task OnInitializedAsync()
        {
            //get the quote
            var result = await httpClient.GetAsync("https://api.chucknorris.io/jokes/random");
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                //deserializen
                quoteModel = JsonSerializer.Deserialize<QuoteModel>(content,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                await Task.Delay(700);
            }
        }
    }
}
