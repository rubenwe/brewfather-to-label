using System.Text.Json.Serialization;

namespace LabelRedirect;

public class Calories
{
    [JsonPropertyName("alcohol")]
    public double Alcohol { get; set; }

    [JsonPropertyName("carbs")]
    public double Carbs { get; set; }

    [JsonPropertyName("total")]
    public double Total { get; set; }

    [JsonPropertyName("kJ")]
    public double KJ { get; set; }
}