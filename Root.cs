using System.Text.Json.Serialization;

namespace LabelRedirect;

[Serializable]
public class Root
{
    // [JsonPropertyName("miscs")]
    // public List<Misc> Miscs { get; set; }

    [JsonPropertyName("abv")]
    public double Abv { get; set; }

    [JsonPropertyName("og")]
    public double Og { get; set; }

    // [JsonPropertyName("mashEfficiency")]
    // public double MashEfficiency { get; set; }
    //
    // [JsonPropertyName("boilTime")]
    // public double BoilTime { get; set; }
    //
    // [JsonPropertyName("_timestamp")]
    // public DateTime Timestamp { get; set; }

    [JsonPropertyName("hops")]
    public List<Hop>? Hops { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    // [JsonPropertyName("postBoilGravity")]
    // public double PostBoilGravity { get; set; }
    //
    // [JsonPropertyName("_ev")]
    // public double Ev { get; set; }
    //
    // [JsonPropertyName("totalGravity")]
    // public double TotalGravity { get; set; }

    [JsonPropertyName("style")]
    public Style Style { get; set; }

    [JsonPropertyName("carbonation")]
    public double Carbonation { get; set; }
  
    [JsonPropertyName("buGuRatio")]
    public double BuGuRatio { get; set; }

    [JsonPropertyName("fgEstimated")]
    public double FgEstimated { get; set; }
 
    [JsonPropertyName("attenuation")]
    public double Attenuation { get; set; }

    [JsonPropertyName("rbRatio")]
    public double RbRatio { get; set; }

    [JsonPropertyName("hopsTotalAmount")]
    public double HopsTotalAmount { get; set; }

    [JsonPropertyName("yeasts")]
    public List<Yeast> Yeasts { get; set; }

    [JsonPropertyName("color")]
    public double Color { get; set; }

    [JsonPropertyName("ibu")]
    public double Ibu { get; set; }
  
    [JsonPropertyName("fermentables")]
    public List<Fermentable> Fermentables { get; set; }
    
    [JsonPropertyName("ogPlato")]
    public double OgPlato { get; set; }

    [JsonPropertyName("nutrition")]
    public Nutrition Nutrition { get; set; }

    [JsonPropertyName("fg")]
    public double Fg { get; set; }

    [JsonPropertyName("fermentableIbu")]
    public double FermentableIbu { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}