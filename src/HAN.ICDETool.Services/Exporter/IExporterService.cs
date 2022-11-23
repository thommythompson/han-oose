using System.IO;

namespace HAN.ICDETool.Services;

public interface IExporterService
{
    public String Export(IList<String> exportData);
}