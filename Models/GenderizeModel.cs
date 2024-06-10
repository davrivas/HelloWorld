using Newtonsoft.Json;

namespace HelloWorld.Models;

public record GenderizeResult(
    [property: JsonProperty("count")] int Count,
    [property: JsonProperty("name")] string Name,
    [property: JsonProperty("gender")] string Gender,
    [property: JsonProperty("probability")] double Probability
);