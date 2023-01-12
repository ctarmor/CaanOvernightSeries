namespace CaanLibraryTests.Mocks
{
    public class MockDaily {
        static public DailyClose MockDailyClosePrev = new DailyClose
        {
            DateStamp = DateTime.Parse("01/26/2023"),
            Open = 100.5M,
            High = 102.0M,
            Low = 99.25M,
            Close = 101.75M
        };
        static public DailyClose MockDailyCloseCur = new DailyClose
        {
            DateStamp = DateTime.Parse("01/27/2023"),
            Open = 102.5M,
            High = 104.0M,
            Low = 95M,
            Close = 97.75M
        };
    }
}