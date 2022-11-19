using HAN.ICDETool.Application;
using HAN.ICDETool.Application.Interfaces.Services;
using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Services;

public class LesMateriaalExporter : ILesMateriaalExporter
{
    public String ExportLesMateriaal(ExportFormaat formaat, LesMateriaal lesMateriaal)
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
        
        return exporter.Export(lesMateriaal.lesInhoud);
    }
}