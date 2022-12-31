namespace HAN.ICDETool.ExporterService.ExportStrategies;

public class CsvExporterStrategy : ExporterStrategy
{
    public CsvExporterStrategy(string exportDirectory) : base(exportDirectory)
    {
    }
    
    public override string ConvertStringListToFile(IList<string> exportData, string exportDirectory)
    {
        string fullPath = exportDirectory + Guid.NewGuid() + ".csv";
        return fullPath;
    }
}