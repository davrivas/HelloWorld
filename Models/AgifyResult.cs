using Newtonsoft.Json;

namespace HelloWorld.Models;

public record AgifyResult(
    [JsonProperty("count")] int Count,
    [JsonProperty("name")] string Name,
    [JsonProperty("age")] int Age
);