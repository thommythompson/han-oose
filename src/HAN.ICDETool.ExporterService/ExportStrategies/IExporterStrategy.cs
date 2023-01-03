using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.ExporterService.ExportStrategies;

public interface IExporterStrategy
{
    CustomFile Export(IList<String> exportData);
}