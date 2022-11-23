using System.IO;

namespace HAN.ICDETool.Services.Exporter;

public interface IExporterService
{
    public String Export(IList<String> exportData);
}