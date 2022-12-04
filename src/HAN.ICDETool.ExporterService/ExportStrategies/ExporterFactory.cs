namespace HAN.ICDETool.ExporterService.ExportStrategies;
public class ExporterFactory
{
    public IExporterService createExporter(ExporterType type, string exportDirectory)
    {
        switch (type)
        {
            case ExporterType.CsvExporter:
                return new CsvExporterStrategy(exportDirectory);
                break;
            case ExporterType.PdfExporter:
                return new PdfExporterStrategy(exportDirectory);
                break;
            case ExporterType.DocxExporter:
                return new DocxExporterStrategy(exportDirectory);
                break;
        }
        return null;
    }
}