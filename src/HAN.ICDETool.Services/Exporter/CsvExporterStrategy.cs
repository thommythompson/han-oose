namespace HAN.ICDETool.Services.Exporter;

public class CsvExporterStrategy : IExporterService
{
    public string Export(IList<string> exportData)
    {
        return "/path/to/csv/file";
    }
}