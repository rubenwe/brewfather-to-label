using System.Text.Json.Serialization;

namespace LabelRedirect;

public class Acid
{
    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("concentration")]
    public int Concentration { get; set; }

    [JsonPropertyName("alkalinityMeqL")]
    public double AlkalinityMeqL { get; set; }
}