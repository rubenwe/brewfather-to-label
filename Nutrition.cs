using System.Text.Json.Serialization;

namespace LabelRedirect;

public class Nutrition
{
    [JsonPropertyName("calories")]
    public Calories Calories { get; set; }

    [JsonPropertyName("carbs")]
    public Carbs Carbs { get; set; }
}