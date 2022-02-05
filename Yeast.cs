using System.Text.Json.Serialization;

namespace LabelRedirect;

public class Yeast
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    // [JsonPropertyName("hidden")]
    // public bool Hidden { get; set; }
    //
    // [JsonPropertyName("_id")]
    // public string Id { get; set; }
    //
    // [JsonPropertyName("bestBeforeDate")]
    // public object BestBeforeDate { get; set; }

    
    // [JsonPropertyName("costPerAmount")]
    // public double CostPerAmount { get; set; }
    //
    // [JsonPropertyName("maxAbv")]
    // public double MaxAbv { get; set; }
    //
    // [JsonPropertyName("type")]
    // public string Type { get; set; }
    //
    // [JsonPropertyName("productId")]
    // public string ProductId { get; set; }
    
    // [JsonPropertyName("form")]
    // public string Form { get; set; }
    //
    // [JsonPropertyName("minAttenuation")]
    // public double? MinAttenuation { get; set; }
    //
    // [JsonPropertyName("maxAttenuation")]
    // public double? MaxAttenuation { get; set; }
    //
    // [JsonPropertyName("minTemp")]
    // public double MinTemp { get; set; }
    //
    // [JsonPropertyName("maxTemp")]
    // public double MaxTemp { get; set; }
    //
    // [JsonPropertyName("userNotes")]
    // public string UserNotes { get; set; }
    //
    // [JsonPropertyName("description")]
    // public string Description { get; set; }
    //
    // [JsonPropertyName("attenuation")]
    // public double Attenuation { get; set; }
    //
    // [JsonPropertyName("flocculation")]
    // public string Flocculation { get; set; }
    //
    // [JsonPropertyName("laboratory")]
    // public string Laboratory { get; set; }
    //
    // [JsonPropertyName("unit")]
    // public string Unit { get; set; }
    //
    // [JsonPropertyName("_created")]
    // public Created Created { get; set; }
    //
    // [JsonPropertyName("fermentsAll")]
    // public bool FermentsAll { get; set; }
}