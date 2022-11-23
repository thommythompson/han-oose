using HAN.ICDETool.Services.HtmlConverter;
using IronPdf;

namespace HAN.ICDETool.Services.Exporter;

public class PdfExporterStrategy : IExporterService
{
    public string Export(IList<String> exportData)
    {
        IHTMLConverter converter = new HTMLConverter();
        String html = converter.ConvertStringListToHtml(exportData);
        
        ChromePdfRenderer Renderer = new ChromePdfRenderer(); // Instantiates Chrome Renderer
        var pdf = Renderer.RenderHtmlAsPdf(html);
        pdf.SaveAs("html_saved.pdf"); // Saves our PdfDocument object as a PDF
        
        return "/path/to/pdf/file";
    }
}