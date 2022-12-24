using HAN.ICDETool.ExporterService.ExportStrategies;

namespace HAN.ICDETool.Tests.Unit;

public class TestExporterService
{
    private ExporterFactory _exporterFactory;
    
    [SetUp]
    public void Setup()
    {
        _exporterFactory = new ExporterFactory();
    }

    [Test]
    public void TestPdfExporter()
    {
        IExporterService exporterService = _exporterFactory.createExporter(ExporterType.PdfExporter, "/Users/thomashofman/Downloads/");

        IList<String> exportData = new List<String>();
        exportData.Add("test");

        String path = exporterService.Export(exportData);
        
        Assert.That(exporterService, Is.TypeOf<PdfExporterStrategy>());
        Assert.That(path, Is.EqualTo("/path/to/pdf/file"));
    }
    
    [Test]
    public void TestCsvExporter()
    {
        IExporterService exporterService = _exporterFactory.createExporter(ExporterType.CsvExporter, "/Users/thomashofman/Downloads/");

        IList<String> exportData = new List<String>();
        exportData.Add("test");

        String path = exporterService.Export(exportData);
        
        Assert.That(exporterService, Is.TypeOf<CsvExporterStrategy>());
        Assert.That(path, Is.EqualTo("/path/to/csv/file"));
    }
    
    [Test]
    public void TestDocxExporter()
    {
        IExporterService exporterService = _exporterFactory.createExporter(ExporterType.DocxExporter, "/Users/thomashofman/Downloads/");
        
        IList<String> exportData = new List<String>();
        exportData.Add("test");

        String path = exporterService.Export(exportData);
        
        Assert.That(exporterService, Is.TypeOf<DocxExporterStrategy>());
        Assert.That(path, Is.EqualTo("/path/to/docx/file"));
    }
}