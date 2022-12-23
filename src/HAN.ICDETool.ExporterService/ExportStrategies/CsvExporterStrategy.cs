namespace HAN.ICDETool.ExporterService.ExportStrategies;

public class CsvExporterStrategy : IExporterService
{
    private string _exportDirectory;
    
    public CsvExporterStrategy(string exportDirectory)
    {
        _exportDirectory = exportDirectory;
    }
    
    public string Export(IList<string> exportData)
    {
        string fullPath = _exportDirectory + Guid.NewGuid() + ".csv";
        return fullPath;
    }
}