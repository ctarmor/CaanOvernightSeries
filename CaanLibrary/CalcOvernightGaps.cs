namespace CaanLibrary;
public class CalcOvernightGaps
{
    /// <summary>
    /// Calculate prev and cur day gaps
    /// </summary>
    public DailyGap GetDayGap(DailyClose prev, DailyClose cur)
    {
        return new DailyGap
        {
            DayBeforeStamp = prev.DateStamp,
            DateStamp = cur.DateStamp,
            AtOpenGap = cur.Open - prev.Close,
            AtCloseGap = cur.Close - prev.Close,
            DayHiGap = cur.High - cur.Open,
            DayCloseGap = cur.Open - cur.Close,
            DayRange = cur.High - cur.Low
        };
    }

    /// <summary>
    /// Iterator for all close prices available
    /// </summary>
    public IEnumerable<DailyGap> GetDayGaps(List<DailyClose> dailyCloses)
    {
        var calc = new CalcOvernightGaps();
        for (int i = 1; i < dailyCloses.Count - 1; i++)
        {
            yield return calc.GetDayGap(dailyCloses[i - 1], dailyCloses[i]);
        }
    }
}
