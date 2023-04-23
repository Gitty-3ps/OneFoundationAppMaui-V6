using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui;

public partial class LoadingPage : ContentPage
{
    private const string ApiUrl = "https://zenquotes.io/api/quotes/";

    public LoadingPage(LoadingPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
        LoadQuote();
    }

    private async void LoadQuote()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync("https://zenquotes.io/api/random");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var quoteObject = JsonConvert.DeserializeObject<JArray>(json)?.FirstOrDefault() as JObject;
            var quote = quoteObject?["q"]?.ToString() ?? "Error loading quote.";
            var author = quoteObject?["a"]?.ToString() ?? "Unknown";
            QuoteLabel.Text = $"{quote}\n\n- {author}";
        }
        else
        {
            QuoteLabel.Text = "Error loading quote.";
        }
    }
}