namespace HAN.ICDETool.ExporterService.ExportStrategies;

public interface IExporterService
{
    public String Export(IList<String> exportData);
}