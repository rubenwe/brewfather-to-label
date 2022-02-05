using System.Text.Json.Serialization;

namespace LabelRedirect;

public class Carbs
{
    [JsonPropertyName("total")]
    public double Total { get; set; }
}