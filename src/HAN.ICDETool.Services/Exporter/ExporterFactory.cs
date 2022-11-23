namespace HAN.ICDETool.Services.Exporter;
public class ExporterFactory
{
    public IExporterService createExporter(ExporterType type)
    {
        switch (type)
        {
            case ExporterType.CsvExporter:
                return new CsvExporterStrategy();
                break;
            case ExporterType.PdfExporter:
                return new PdfExporterStrategy();
                break;
            case ExporterType.DocxExporter:
                return new DocxExporterStrategy();
                break;
        }
        return null;
    }
}