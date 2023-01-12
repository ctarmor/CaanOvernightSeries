using System.Text.Json;

public class CsvLoader
{
    /// <summary>
    /// Paser a line imported from a file into.
    /// </summary>
    static public DailyClose ParseLine(string line)
    {
        // Date,Open,High,Low,Close
        //  ["01/10/2023","3,888.57","3,919.83","3,877.29","3,919.25"]

        var fields = line.Split('^');

        return new DailyClose
        {
            DateStamp = DateTime.Parse(fields[0]),
            Open = decimal.Parse(fields[1]),
            High = decimal.Parse(fields[2]),
            Low = decimal.Parse(fields[3]),
            Close = decimal.Parse(fields[4])
        };
    }
}