using Newtonsoft.Json;

namespace HelloWorld.Models;

public record Country(
    [property: JsonProperty("country_id")] string CountryId,
    [property: JsonProperty("probability")] double Probability
);

public record NationalizeResult(
    [property: JsonProperty("count")] int Count,
    [property: JsonProperty("name")] string Name,
    [property: JsonProperty("country")] IReadOnlyList<Country> Country
);