namespace CaanLibrary;
public class CalcOvernightGaps
{
    static public DailyGap GetDayGap(DailyClose prev, DailyClose cur) { 
        return new DailyGap {
            DayBeforeStamp = prev.DateStamp,
            DateStamp = cur.DateStamp,

            AtOpenGap = cur.Open - prev.Close,

            AtCloseGap = cur.Close - cur.Open,

            DayHiGap = cur.High - cur.Open,

            DayCloseGap = cur.Open - cur.Close,

            DayRange = cur.High - cur.Low
         };
        }
}
