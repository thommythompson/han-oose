using Xceed.Words.NET;

namespace HAN.ICDETool.ExporterService.ExportStrategies;

public class DocxExporterStrategy : ExporterStrategy
{
    public DocxExporterStrategy(string exportDirectory) : base(exportDirectory)
    {
    }
    
    public override string ConvertStringListToFile(IList<string> exportData, string exportDirectory)
    {
        string fullPath = exportDirectory + Guid.NewGuid() + ".docx";
        
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