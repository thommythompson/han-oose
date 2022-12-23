using Xceed.Words.NET;

namespace HAN.ICDETool.ExporterService.ExportStrategies;

public class DocxExporterStrategy : IExporterService
{
    private string _exportDirectory;
    
    public DocxExporterStrategy(string exportDirectory)
    {
        _exportDirectory = exportDirectory;
    }
    
    public string Export(IList<String> exportData)
    {
        string fullPath = _exportDirectory + Guid.NewGuid() + ".docx";
        
        var document = DocX.Create(fullPath);
        
        foreach(String line in exportData)
        {
            var p = document.InsertParagraph();
            p.Append(line);
        }
        
        document.Save();
        
        return fullPath;
    }
}