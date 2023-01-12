/// <summary>
/// Single Day price.
/// </summary>
public record struct DailyClose
{
    public DateTime DateStamp { get; set; }
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
}