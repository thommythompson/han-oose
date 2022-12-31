using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.ExporterService.ExportStrategies;

public interface IExporterFactory
{
    void ChooseExportType(ExportFormaat type);
    CustomFile Export(IList<string> exportData);
}