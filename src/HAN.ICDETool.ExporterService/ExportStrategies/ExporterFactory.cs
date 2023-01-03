using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.ExporterService.ExportStrategies;
public class ExporterFactory : IExporterFactory
{
    private readonly string _exportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files/");
    private IExporterStrategy? _exporterStrategy;

    public void ChooseExportType(ExportFormaat type)
    {
        switch (type)
        {
            case ExportFormaat.Csv:
                _exporterStrategy = new CsvExporterStrategy(_exportDirectory);
                break;
            case ExportFormaat.Pdf:
                _exporterStrategy =  new PdfExporterStrategy(_exportDirectory);
                break;
            case ExportFormaat.Docx:
                _exporterStrategy =  new DocxExporterStrategy(_exportDirectory);
                break;
        }
    }
    
    public CustomFile Export(IList<string> exportData)
    {
        var result = _exporterStrategy.Export(exportData);
        return result;
    }
}