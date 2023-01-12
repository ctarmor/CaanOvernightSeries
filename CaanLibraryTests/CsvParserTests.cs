using CaanLibrary;

namespace CaanLibraryTests;

[TestClass]
public class CsvParserTests
{
    [TestMethod]
    public void TestParseLine()
    {
        var cleanLine = "01/10/2023,\"3,888.57\",\"3,919.83\",\"3,877.29\",\"3,919.25\""
            .Replace(@",""", "^")
            .Replace(@"""", "");

        var target = CsvLoader.ParseLine(cleanLine);

        var result = new DailyClose
        {
            DateStamp = DateTime.Parse("01/10/2023"),
            Open = 3888.57M,
            High = 3919.83M,
            Low = 3877.29M,
            Close = 3919.25M
        };

        Assert.AreEqual(target, result);
    }
}