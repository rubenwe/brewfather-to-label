// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
// ReSharper disable CollectionNeverUpdated.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.Net.Mime;
using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/", () => HtmlResponse(@"
<h1>Upload BrewFather Json</h1>
<form action=""/upload"" method=""POST"" enctype=""multipart/form-data"">
    <p>
        <label for=""file"">Datei:</label>
        <input id=""file"" name=""file"" type=""file"" />
    </p>
    <p>
        <input type=""submit"" value=""Upload""/>
    </p>
</form>"));

app.MapPost("/upload", async Task<IResult>(HttpRequest request) =>
{
    if (!request.HasFormContentType)
        return Results.BadRequest();

    var form = await request.ReadFormAsync();
    var formFile = form.Files["file"];

    if (formFile is null || formFile.Length == 0)
        return Results.BadRequest();

    await using var stream = formFile.OpenReadStream();

    var data = await JsonSerializer.DeserializeAsync<BrewFatherRecipe>(stream);
    if (data == null) return HtmlResponse("<h2>Daten sind futsch!</h2><p>Haste Pech!</p>");

    var inputs = new List<(string fieldName, string label, string value, bool includeLabel)>
    {
        ("Text1", "Name", data.name ?? string.Empty, false),
        ("Text2", "Stil", data.style?.name ?? string.Empty, false),
        ("Text3", "Stammwürze", data.ogPlato.ToString("F1") + "°P", true),
        ("Text4", "Alkohol", data.abv.ToString("F1") + "%", true),
        ("Text5", "Malze", (data.fermentables ?? Enumerable.Empty<Fermentable>())
            .Where(fermentable => fermentable.notFermentable == false)
            .Where(fermentable => fermentable.name != null)
            .OrderByDescending(fermentable => fermentable.amount)
            .Select(fermentable => fermentable.name!)
            .Distinct()
            .StringJoin(), true),
        ("Text6", "Hopfen", (data.hops ?? Enumerable.Empty<Hop>()) 
            .Where(hop => hop.name != null)
            .ToLookup(hop => hop.name!)
            .OrderByDescending(grp => grp.Sum(hop => hop.amount))
            .Select(grp => grp.Key)
            .StringJoin(), true),
        ("Text7", "Hefen", (data.yeasts ?? Enumerable.Empty<Yeast>())
            .Where(yeast => yeast.name != null)
            .OrderByDescending(yeast => yeast.amount)
            .Select(yeast => yeast.name!)
            .Distinct()
            .StringJoin(), true),
        ("Text8", "Bittere", data.ibu.ToString("N0") + " IBU", true),
        ("Text9", "Farbe", (data.color * 1.97).ToString("N0") + " EBC", true),
        ("Text10", "Autor", data.author ?? string.Empty, true),
        ("Text11", "Abfülldatum", DateTime.Now.ToString("dd.MM.yyyy"), true),
        ("type", "LabelTyp", "Label_23", false),
        ("labelsRow", "Label pro Zeile", "1", false),
        ("labelsPage", "Zeilen pro Seite", "13", false)
    };

    var fields = inputs.Select(input =>
    {
        var (fieldName, label, value, includeLabel) = input;
        var inputValue = includeLabel ? $"{label}: {value}" : value;
        return $@"
    <p>
        <label for=""{fieldName}"">{label}:</label>
        <input type=""text"" id=""{fieldName}"" name=""{fieldName}"" value=""{inputValue}"" />
    </p>
";
    }).StringJoin(string.Empty);

    var content = $@"
<h1>Daten prüfen</h1>
<form action=""https://braureka.de/rezepte/label-print"" method=""POST"">
{fields}
    <p>
        <label for=""colorSchema"">Farbe:</label>
        <select id=""colorSchema"" name=""colorSchema"">
            <option value=""cs1"">weiß</option>
            <option value=""cs2"">gold</option>
            <option value=""cs3"">bernstein</option>
            <option value=""cs4"">braun</option>
            <option value=""cs5"">schwarz</option>
        </select>
    </p>
    <p>
        <input type=""submit"" value=""Ab dafür!"" />
    </p>
</form>
";

    return HtmlResponse(content);
});

app.Run();


IResult HtmlResponse(string s)
{
    var html = $@"
<!DOCTYPE html>
<html lang=""de"">
<head>
    <meta charset=""utf-8""/>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto"">
    <style>
        body {{
            font-family: Roboto;
        }}

        input[type=text] {{ 
            width: 550px;
        }}

        label {{
            width: 150px;
            display: inline-block;
        }}
    </style>
</head>
<body>
{s}
</body>
</html>
";

    return new HtmlResult(html);
}

static class Extensions
{
    public static string StringJoin(this IEnumerable<string> strings, string separator = ", ") => string.Join(separator, strings);
}

class HtmlResult : IResult
{
    private readonly string _htmlContent;

    public HtmlResult(string htmlContent)
    {
        _htmlContent = htmlContent;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        var bytes = Encoding.UTF8.GetBytes(_htmlContent);
        httpContext.Response.ContentType = MediaTypeNames.Text.Html;
        httpContext.Response.ContentLength = bytes.Length;
        await httpContext.Response.WriteAsync(_htmlContent);
    }
}

public class BrewFatherRecipe
{
    public string? name { get; set; }
    public double abv { get; set; }
    public double color { get; set; }
    public double ibu { get; set; } 
    public double ogPlato { get; set; }
    public string? author { get; set; }
    
    public Style? style { get; set; }
    
    public List<Fermentable>? fermentables { get; set; }
    public List<Hop>? hops { get; set; }
    public List<Yeast>? yeasts { get; set; }
}

public class Style
{
    public string? name { get; set; }
}

public class Fermentable
{
    public bool notFermentable { get; set; }
    public double amount { get; set; }
    public string? name { get; set; }
}

public class Hop
{
    public double amount { get; set; }
    public string? name { get; set; }
}

public class Yeast
{
    public string? name { get; set; }
    public int amount { get; set; }
}