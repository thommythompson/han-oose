using HAN.ICDETool.Services.HtmlConverter;
using Xceed.Words.NET;

namespace HAN.ICDETool.Services.Exporter;

public class DocxExporterStrategy : IExporterService
{
    public string Export(IList<String> exportData)
    {
        var document = DocX.Create("NewDocument.docx");
        
        foreach(String line in exportData)
        {
            var p = document.InsertParagraph();
            p.Append(line);
        }
        
        document.Save();
        
        return "/path/to/docx/file";
    }
}