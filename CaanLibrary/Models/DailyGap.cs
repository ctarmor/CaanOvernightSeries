public record struct DailyGap {
    public DateTime DayBeforeStamp { get; set; }
    public DateTime DateStamp { get; set; }

    /// <summary>
    /// Gap from the previos day at open
    /// </summary>
    public decimal AtOpenGap { get; set; }

    /// <summary>
    /// Gap from open to close
    /// </summary>
    public decimal AtCloseGap { get; set; }

    /// <summary>
    /// Highest trade for the day
    /// </summary>
    public decimal DayHiGap { get; set; }

    /// <summary>
    /// Lowest trade for the day
    /// </summary>
    public decimal DayCloseGap { get; set; }

    /// <summary>
    /// Day Range
    /// </summary>
    public decimal DayRange { get; set; }
}