using HelloWorld.Constants;
using HelloWorld.Helpers;
using HelloWorld.Models;
using Newtonsoft.Json;

namespace HelloWorld.Programs.Implementations;

public class PersonNameProgram : IProgram, IAsyncProgram
{
    private const string AgifyUrl = "https://api.agify.io?name={0}";
    private const string GenderizeUrl = "https://api.genderize.io?name={0}";
    private const string NationalizeUrl = "https://api.nationalize.io/?name={0}";

    private static string GetAgifyUrl(string name) => string.Format(AgifyUrl, name);
    private static string GetGenderizeUrl(string name) => string.Format(GenderizeUrl, name);
    private static string GetNationalizeUrl(string name) => string.Format(NationalizeUrl, name);

    public void Run()
    {
        var task = RunAsync();
        task.Wait();
    }

    public async Task RunAsync()
    {
        var name = ConsoleHelpers.GetString("Enter person name:");

        if (string.IsNullOrWhiteSpace(name)) return;

        Console.WriteLine("Loading results...");

        using var httpClient = new HttpClient();

        var tasks = await Task.WhenAll(httpClient.GetAsync(GetAgifyUrl(name)),
            httpClient.GetAsync(GetGenderizeUrl(name)),
            httpClient.GetAsync(GetNationalizeUrl(name)));

        var results = await Task.WhenAll(tasks.Select(x => x.Content.ReadAsStringAsync()));

        Console.WriteLine($"Name: {name}");

        var agifyObject = JsonConvert.DeserializeObject<AgifyResult>(results[0]);
        Console.WriteLine($"Age: {agifyObject?.Age}");

        var genderizeObject = JsonConvert.DeserializeObject<GenderizeResult>(results[1]);
        Console.WriteLine($"Gender: {genderizeObject?.Gender}");

        var nationalizeObject = JsonConvert.DeserializeObject<NationalizeResult>(results[2]);
        var countryCode = nationalizeObject?.Country[0]?.CountryId ?? string.Empty;
        _ = AppConstants.CountryNationalities.TryGetValue(countryCode, out string? nationality);
        Console.WriteLine($"Nationality: {nationality ?? countryCode}");
    }
}