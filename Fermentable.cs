using System.Text.Json.Serialization;

namespace LabelRedirect;

public class Fermentable
{
    // [JsonPropertyName("notes")]
    // public string Notes { get; set; }
    //
    // [JsonPropertyName("hidden")]
    // public bool Hidden { get; set; }
    //
    // [JsonPropertyName("_id")]
    // public string Id { get; set; }

    // [JsonPropertyName("acid")]
    // public object Acid { get; set; }
    //
    // [JsonPropertyName("fan")]
    // public object Fan { get; set; }
    //
    // [JsonPropertyName("potentialPercentage")]
    // public double PotentialPercentage { get; set; }

    [JsonPropertyName("notFermentable")]
    public bool NotFermentable { get; set; }

    // [JsonPropertyName("ibuPerAmount")]
    // public object IbuPerAmount { get; set; }
    //
    // [JsonPropertyName("_timestamp")]
    // public Timestamp Timestamp { get; set; }
    //
    // [JsonPropertyName("color")]
    // public double Color { get; set; }
    //
    // [JsonPropertyName("potential")]
    // public double Potential { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    // [JsonPropertyName("percentage")]
    // public double Percentage { get; set; }
    //
    // [JsonPropertyName("diastaticPower")]
    // public object DiastaticPower { get; set; }
    //
    // [JsonPropertyName("_created")]
    // public Created Created { get; set; }
    //
    // [JsonPropertyName("fgdb")]
    // public object Fgdb { get; set; }
    //
    // [JsonPropertyName("costPerAmount")]
    // public double CostPerAmount { get; set; }
    //
    // [JsonPropertyName("cgdb")]
    // public object Cgdb { get; set; }
    //
    // [JsonPropertyName("_timestamp_ms")]
    // public object TimestampMs { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    // [JsonPropertyName("protein")]
    // public object Protein { get; set; }
    //
    // [JsonPropertyName("substitutes")]
    // public string Substitutes { get; set; }
    //
    // [JsonPropertyName("moisture")]
    // public object Moisture { get; set; }
    //
    // [JsonPropertyName("maxInBatch")]
    // public object MaxInBatch { get; set; }
    //
    // [JsonPropertyName("supplier")]
    // public string Supplier { get; set; }
    //
    // [JsonPropertyName("origin")]
    // public string Origin { get; set; }
    //
    // [JsonPropertyName("friability")]
    // public object Friability { get; set; }
    //
    // [JsonPropertyName("_version")]
    // public string Version { get; set; }
    //
    // [JsonPropertyName("manufacturingDate")]
    // public object ManufacturingDate { get; set; }
    //
    // [JsonPropertyName("grainCategory")]
    // public string GrainCategory { get; set; }
    //
    // [JsonPropertyName("bestBeforeDate")]
    // public object BestBeforeDate { get; set; }
    //
    // [JsonPropertyName("inventory")]
    // public double Inventory { get; set; }
    //
    // [JsonPropertyName("type")]
    // public string Type { get; set; }
    //
    // [JsonPropertyName("coarseFineDiff")]
    // public object CoarseFineDiff { get; set; }
    //
    // [JsonPropertyName("usedIn")]
    // public string UsedIn { get; set; }
    //
    // [JsonPropertyName("attenuation")]
    // public double? Attenuation { get; set; }
    //
    // [JsonPropertyName("userNotes")]
    // public string UserNotes { get; set; }
    //
    // [JsonPropertyName("time")]
    // public int? Time { get; set; }
    //
    // [JsonPropertyName("use")]
    // public string Use { get; set; }
}