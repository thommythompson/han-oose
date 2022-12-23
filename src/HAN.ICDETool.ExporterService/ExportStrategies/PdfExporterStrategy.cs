using HAN.ICDETool.ExporterService.HtmlConverter;

using IronPdf;

namespace HAN.ICDETool.ExporterService.ExportStrategies;

public class PdfExporterStrategy : IExporterService
{
    private string _exportDirectory;
    
    public PdfExporterStrategy(string exportDirectory)
    {
        _exportDirectory = exportDirectory;
    }
    
    public string Export(IList<String> exportData)
    {
        IHTMLConverter converter = new HTMLConverter();
        String html = converter.ConvertStringListToHtml(exportData);
        
        ChromePdfRenderer Renderer = new ChromePdfRenderer(); // Instantiates Chrome Renderer
        var pdf = Renderer.RenderHtmlAsPdf(html);

        string fullPath = _exportDirectory + Guid.NewGuid() + ".pdf";
        pdf.SaveAs(fullPath); // Saves our PdfDocument object as a PDF
        
        return fullPath;
    }
}