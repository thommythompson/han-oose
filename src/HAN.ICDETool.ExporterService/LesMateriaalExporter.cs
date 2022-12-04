using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.ExporterService.ExportStrategies;

namespace HAN.ICDETool.ExporterService;

public class LesMateriaalExporter : ILesMateriaalExporter
{
    public string ExportLesMateriaal(ExportFormaat formaat, LesMateriaal lesMateriaal)
    {
        ExporterFactory factory = new ExporterFactory();
        IExporterService exporter;
        
        switch (formaat)
        {
            case ExportFormaat.Csv:
                exporter = factory.createExporter(ExporterType.CsvExporter);
                break;
            case ExportFormaat.Docx:
                exporter = factory.createExporter(ExporterType.DocxExporter);
                break;
            case ExportFormaat.Pdf:
                exporter = factory.createExporter(ExporterType.PdfExporter);
                break;
            default:
                exporter = null;
                break;
        }

        IList<String> lesMateriaalLines = new List<string>();
        foreach(LesMateriaalLine line in lesMateriaal.Inhoud)
        {
            lesMateriaalLines.Add(line.Line);
        }
        
        return exporter.Export(lesMateriaalLines);
    }
}