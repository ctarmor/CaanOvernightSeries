namespace CaanLibrary;
public class CalcOvernightGaps
{
    static public DailyGap GetDayGap(DailyClose prev, DailyClose cur) { 
        return new DailyGap {
            DayBeforeStamp = prev.DateStamp,
            DateStamp = cur.DateStamp,

            AtOpenGap = cur.Open - prev.Close,

            AtCloseGap = cur.Close - cur.Close,

            DayHiGap = cur.High - cur.Open,

            DayCloseGap = cur.Open - cur.Open,

            DayRange = cur.High - cur.Low
         };
        }
}
