using System.Text;

namespace HAN.ICDETool.ExporterService.ExportStrategies;

public class CsvExporterStrategy : ExporterStrategy
{
    public CsvExporterStrategy(string exportDirectory) : base(exportDirectory)
    {
    }
    
    public override string ConvertStringListToFile(IList<string> exportData, string exportDirectory)
    {
        string fullPath = exportDirectory + Guid.NewGuid() + ".csv";

        var stringBuilder = new StringBuilder();

        int x = 0;
        foreach (var line in exportData)
        {
            stringBuilder.AppendLine($"{x}, {line}");
            x++;
        }

        System.IO.File.WriteAllText(fullPath, stringBuilder.ToString());
        
        return fullPath;
    }
}