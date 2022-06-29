//namespace IgApplication.Data.DataSource1; // Razor won't recognize third level namespace
namespace IgApplication.DataSource1;

public class OReillyBooksType
{
    public Value[] Value { get; set; } = Array.Empty<Value>();
}

public class Value
{
    public double? RowId { get; set; }
    public string? ImageUrl { get; set; }
    public string? ISBN { get; set; }
    public string? Price { get; set; }
    public string? PublishDate { get; set; }
    public string? Title { get; set; }
    public string? URL { get; set; }
}
