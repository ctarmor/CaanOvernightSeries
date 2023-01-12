using CaanLibrary;

namespace CaanLibraryTests;

[TestClass]
public class CalcOvernightGapsTests
{
    [TestMethod]
    public void TestGetDayGap()
    {
        var target = CalcOvernightGaps.GetDayGap(Mocks.MockDaily.MockDailyClosePrev, Mocks.MockDaily.MockDailyCloseCur);

        var result = new DailyGap
        {
            DayBeforeStamp = DateTime.Parse("01/26/2023"),
            DateStamp = DateTime.Parse("01/27/2023"),
            AtOpenGap = 0.75M,
            AtCloseGap = -4.75M,
            DayHiGap = 1.5M,
            DayCloseGap = 4.75M,
            DayRange = 9.0M
        };

        Assert.AreEqual(target, result);
    }

    [TestMethod]
    public void TestGetDayGaps()
    {
        
    }
}