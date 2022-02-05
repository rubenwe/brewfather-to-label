using System.Text.Json.Serialization;

namespace LabelRedirect;

public class Style
{
    // [JsonPropertyName("_id")]
    // public string Id { get; set; }
    //
    // [JsonPropertyName("fgMin")]
    // public double FgMin { get; set; }
    //
    // [JsonPropertyName("categoryNumber")]
    // public string CategoryNumber { get; set; }
    //
    // [JsonPropertyName("carbonationStyle")]
    // public string CarbonationStyle { get; set; }
    //
    // [JsonPropertyName("rbrMax")]
    // public double RbrMax { get; set; }
    //
    // [JsonPropertyName("lovibondMin")]
    // public double LovibondMin { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    // [JsonPropertyName("styleLetter")]
    // public string StyleLetter { get; set; }
    //
    // [JsonPropertyName("lovibondMax")]
    // public double LovibondMax { get; set; }
    //
    // [JsonPropertyName("type")]
    // public string Type { get; set; }
    //
    // [JsonPropertyName("ibuMax")]
    // public double IbuMax { get; set; }
    //
    // [JsonPropertyName("styleGuide")]
    // public string StyleGuide { get; set; }
    //
    // [JsonPropertyName("colorMin")]
    // public double ColorMin { get; set; }
    //
    // [JsonPropertyName("fgMax")]
    // public double FgMax { get; set; }
    //
    // [JsonPropertyName("ogMin")]
    // public double OgMin { get; set; }
    //
    // [JsonPropertyName("buGuMax")]
    // public double BuGuMax { get; set; }
    //
    // [JsonPropertyName("abvMin")]
    // public double AbvMin { get; set; }
    //
    // [JsonPropertyName("colorMax")]
    // public double ColorMax { get; set; }
    //
    // [JsonPropertyName("ibuMin")]
    // public double IbuMin { get; set; }
    //
    // [JsonPropertyName("abvMax")]
    // public double AbvMax { get; set; }
    //
    // [JsonPropertyName("rbrMin")]
    // public double RbrMin { get; set; }
    //
    // [JsonPropertyName("ogMax")]
    // public double OgMax { get; set; }
    //
    // [JsonPropertyName("buGuMin")]
    // public double BuGuMin { get; set; }
    //
    // [JsonPropertyName("category")]
    // public string Category { get; set; }
}