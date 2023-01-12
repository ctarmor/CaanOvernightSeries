public record struct DailyClose
{
    // Date,Open,High,Low,Close
    // 01/10/2023,"3,888.57","3,919.83","3,877.29","3,919.25"
    public DateTime DateStamp { get; set; }
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
}