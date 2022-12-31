using System.Diagnostics.CodeAnalysis;
using System.Transactions;
using HAN.ICDETool.ExporterService.ExportStrategies;
using HAN.ICDETool.Services.Interfaces;

namespace HAN.ICDETool.Tests.Unit;

public class TestExporterService
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [Ignore("Dependecies not available at MacOS ARM")]
    public void TestStrategyPdf()
    {
        IExporterFactory exporterFactory = new ExporterFactory();
        exporterFactory.ChooseExportType(ExportFormaat.Pdf);
        
        IList<String> exportData = new List<String>();
        exportData.Add("test");

        var file = exporterFactory.Export(exportData);

        Assert.NotNull(file.FileContents);
        Assert.That(file.FileName, Contains.Substring(".pdf"));
    }
    
    [Test]
    public void TestStrategyCsv()
    {
        IExporterFactory exporterFactory = new ExporterFactory();
        exporterFactory.ChooseExportType(ExportFormaat.Csv);
        
        IList<String> exportData = new List<String>();
        exportData.Add("test");

        var file = exporterFactory.Export(exportData);

        Assert.NotNull(file.FileContents);
        Assert.That(file.FileName, Contains.Substring(".csv"));
    }
    
    [Test]
    public void TestStrategyDocx()
    {
        IExporterFactory exporterFactory = new ExporterFactory();
        exporterFactory.ChooseExportType(ExportFormaat.Docx);
        
        IList<String> exportData = new List<String>();
        exportData.Add("test");

        var file = exporterFactory.Export(exportData);

        Assert.NotNull(file.FileContents);
        Assert.That(file.FileName, Contains.Substring(".docx"));
    }
}