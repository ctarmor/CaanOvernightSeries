using System.Text.Json;
using CaanLibrary;

namespace CaanLibraryTests;

[TestClass]
public class CsvParserTests
{
    [TestMethod]
    public void TestParseLines()
    {
        var lines = new List<string> {
            "Date,Open,High,Low,Close",
            "01/10/2023,\"3,888.57\",\"3,919.83\",\"3,877.29\",\"3,919.25\"",
            "01/10/2023,\"3,888.57\",\"3,919.83\",\"3,877.29\",\"3,919.25\""
        };

        var target = CsvLoader.ParseLines(lines);

        var result = new List<DailyClose> {
            new DailyClose {
                DateStamp = DateTime.Parse("01/10/2023"),
                Open = 3888.57M,
                High = 3919.83M,
                Low = 3877.29M,
                Close = 3919.25M
            },
            new DailyClose {
                DateStamp = DateTime.Parse("01/10/2023"),
                Open = 3888.57M,
                High = 3919.83M,
                Low = 3877.29M,
                Close = 3919.25M
            }
        };

        Assert.IsTrue(target.SequenceEqual(result));
    }

    [TestMethod]
    public void TestParseLine()
    {
        var target = CsvLoader.ParseLine("01/10/2023,\"3,888.57\",\"3,919.83\",\"3,877.29\",\"3,919.25\"");

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