namespace HAN.ICDETool.ExporterService.ExportStrategies;

public class CsvExporterStrategy : IExporterService
{
    public string Export(IList<string> exportData)
    {
        return "/path/to/csv/file";
    }
}