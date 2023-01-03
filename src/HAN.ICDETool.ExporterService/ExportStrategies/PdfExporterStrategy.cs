using HAN.ICDETool.ExporterService.HtmlConverter;

using IronPdf;

namespace HAN.ICDETool.ExporterService.ExportStrategies;

public class PdfExporterStrategy : ExporterStrategy
{
    public PdfExporterStrategy(string exportDirectory) : base(exportDirectory)
    {
    }

    public override string ConvertStringListToFile(IList<string> exportData, string exportDirectory)
    {
        IHTMLConverter converter = new HTMLConverter();
        String html = converter.ConvertStringListToHtml(exportData);
        
        ChromePdfRenderer Renderer = new ChromePdfRenderer(); // Instantiates Chrome Renderer
        var pdf = Renderer.RenderHtmlAsPdf(html);

        string fullPath = exportDirectory + Guid.NewGuid() + ".pdf";
        pdf.SaveAs(fullPath); // Saves our PdfDocument object as a PDF
        
        return fullPath;
    }
}