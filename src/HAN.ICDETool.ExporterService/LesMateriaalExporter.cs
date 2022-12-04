using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.ExporterService.ExportStrategies;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.ExporterService;

public class LesMateriaalExporter : ILesMateriaalExporter
{
    private readonly string _exportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files/");

    public CustomFile ExportLesMateriaal(ExportFormaat formaat, LesMateriaal lesMateriaal)
    {
        Directory.CreateDirectory(_exportDirectory);
        
        ExporterFactory factory = new ExporterFactory();
        IExporterService exporter;
        
        switch (formaat)
        {
            case ExportFormaat.Csv:
                exporter = factory.createExporter(ExporterType.CsvExporter, _exportDirectory);
                break;
            case ExportFormaat.Docx:
                exporter = factory.createExporter(ExporterType.DocxExporter, _exportDirectory);
                break;
            case ExportFormaat.Pdf:
                exporter = factory.createExporter(ExporterType.PdfExporter, _exportDirectory);
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

        string filePath = exporter.Export(lesMateriaalLines);
        
        return new CustomFile
        {
            ContentType = "application/octet-stream",
            FileName = filePath,
            FileContents = File.ReadAllBytes(filePath)
        };
    }
}