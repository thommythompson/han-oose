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
    [Ignore("Dependecies not available at MacOS ARM")]
    public void TestPdfExporter()
    {
        IExporterService exporterService = _exporterFactory.createExporter(ExporterType.PdfExporter, "/Users/thomashofman/Downloads/");

        IList<String> exportData = new List<String>();
        exportData.Add("test");

        String path = exporterService.Export(exportData);
        
        Assert.That(exporterService, Is.TypeOf<PdfExporterStrategy>());
        Assert.That(path, Contains.Substring("/Users/thomashofman/Downloads/"));
    }
    
    [Test]
    public void TestCsvExporter()
    {
        IExporterService exporterService = _exporterFactory.createExporter(ExporterType.CsvExporter, "/Users/thomashofman/Downloads/");

        IList<String> exportData = new List<String>();
        exportData.Add("test");

        String path = exporterService.Export(exportData);
        
        Assert.That(exporterService, Is.TypeOf<CsvExporterStrategy>());
        Assert.That(path, Contains.Substring("/Users/thomashofman/Downloads/"));
    }
    
    [Test]
    public void TestDocxExporter()
    {
        IExporterService exporterService = _exporterFactory.createExporter(ExporterType.DocxExporter, "/Users/thomashofman/Downloads/");
        
        IList<String> exportData = new List<String>();
        exportData.Add("test");

        String path = exporterService.Export(exportData);
        
        Assert.That(exporterService, Is.TypeOf<DocxExporterStrategy>());
        Assert.That(path, Contains.Substring("/Users/thomashofman/Downloads/"));
    }
}