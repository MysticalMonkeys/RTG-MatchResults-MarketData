using System.IO;

var filePath = Path.Combine(Directory.GetCurrentDirectory(), "match83_events.csv");

using (StreamWriter writer = new StreamWriter("market_data_match.csv"))
{
    foreach (var line in File.ReadLines(filePath))
    {
        if (line.Contains("Trade") || line.Contains("Hedge"))
            continue;
            
        var comp = line.Split(',');
        if (Int32.TryParse(comp[7], out int result))
            writer.WriteLine($"{comp[0]},{comp[4]},{comp[2]},{comp[3]},{comp[5]},{comp[6]},{result / 100},{comp[8]}");

        else
        {   
            int inst;
            inst = comp[3].Length == 9 ? 0 : 1;
            writer.WriteLine($"{comp[0]},{inst},{comp[2]},{comp[3]},{comp[5]},{comp[6]},,");
        }
    }
}

