namespace CaanLibrary;
public class CalcOvernightGaps
{
    /// <summary>
    /// Calculate prev and cur day gaps
    /// </summary>
    static public DailyGap GetDayGap(DailyClose prev, DailyClose cur)
    {
        return new DailyGap
        {
            DayBeforeStamp = prev.DateStamp,
            DateStamp = cur.DateStamp,
            AtOpenGap = cur.Open - prev.Close,
            AtCloseGap = cur.Close - cur.Open,
            DayHiGap = cur.High - cur.Open,
            DayCloseGap = cur.Open - cur.Close,
            DayRange = cur.High - cur.Low
        };
    }

    /// <summary>
    /// Iterator for all close prices available
    /// </summary>
    static public IEnumerable<DailyGap> GetDayGaps(List<DailyClose> dailyCloses)
    {
        for (int i = 1; i < dailyCloses.Count - 1; i++)
        {
            yield return CalcOvernightGaps.GetDayGap(dailyCloses[i - 1], dailyCloses[i]);
        }
    }
}
