using System.Text.Json.Serialization;

namespace LabelRedirect;

public class Hop
{
    [JsonPropertyName("origin")]
    public string Origin { get; set; }

    // [JsonPropertyName("_timestamp")]
    // public Timestamp Timestamp { get; set; }
    //
    // [JsonPropertyName("usedIn")]
    // public string UsedIn { get; set; }

    // [JsonPropertyName("_timestamp_ms")]
    // public object TimestampMs { get; set; }
    //
    // [JsonPropertyName("userNotes")]
    // public string UserNotes { get; set; }
    //
    // [JsonPropertyName("caryophyllene")]
    // public object Caryophyllene { get; set; }
    //
    // [JsonPropertyName("manufacturingDate")]
    // public object ManufacturingDate { get; set; }
    //
    // [JsonPropertyName("hidden")]
    // public bool Hidden { get; set; }
    //
    // [JsonPropertyName("humulene")]
    // public object Humulene { get; set; }
    //
    // [JsonPropertyName("inventory")]
    // public double Inventory { get; set; }
    //
    // [JsonPropertyName("bestBeforeDate")]
    // public object BestBeforeDate { get; set; }
    //
    // [JsonPropertyName("substitutes")]
    // public string Substitutes { get; set; }

    [JsonPropertyName("ibu")]
    public double Ibu { get; set; }
    //
    // [JsonPropertyName("alpha")]
    // public double Alpha { get; set; }
    //
    // [JsonPropertyName("myrcene")]
    // public object Myrcene { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    // [JsonPropertyName("_id")]
    // public string Id { get; set; }
    //
    // [JsonPropertyName("beta")]
    // public double? Beta { get; set; }

    [JsonPropertyName("use")]
    public string Use { get; set; }
    //
    // [JsonPropertyName("notes")]
    // public string Notes { get; set; }
    //
    // [JsonPropertyName("farnesene")]
    // public object Farnesene { get; set; }
    //
    // [JsonPropertyName("cohumulone")]
    // public object Cohumulone { get; set; }
    //
    // [JsonPropertyName("timeUnit")]
    // public string TimeUnit { get; set; }
    //
    // [JsonPropertyName("temp")]
    // public object Temp { get; set; }
    //
    // [JsonPropertyName("hsi")]
    // public int? Hsi { get; set; }

    // [JsonPropertyName("oil")]
    // public object Oil { get; set; }
    //
    // [JsonPropertyName("type")]
    // public string Type { get; set; }
    //
    // [JsonPropertyName("_version")]
    // public string Version { get; set; }
    //
    // [JsonPropertyName("time")]
    // public int Time { get; set; }
    //
    // [JsonPropertyName("costPerAmount")]
    // public double CostPerAmount { get; set; }

    [JsonPropertyName("usage")]
    public string Usage { get; set; }

    [JsonPropertyName("year")]
    public int? Year { get; set; }

    // [JsonPropertyName("_created")]
    // public Created Created { get; set; }
    //
    // [JsonPropertyName("actualTime")]
    // public long? ActualTime { get; set; }
    //
    // [JsonPropertyName("day")]
    // public int? Day { get; set; }
}