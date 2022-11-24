using HAN.ICDETool.Application;
using HAN.ICDETool.Application.Services.Interfaces;
using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Services.Exporter;

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

        IList<String> lesMateriaalLines = new List<string>();
        foreach(LesMateriaalLine line in lesMateriaal.Inhoud)
        {
            lesMateriaalLines.Add(line.Line);
        }
        
        return exporter.Export(lesMateriaalLines);
    }
}