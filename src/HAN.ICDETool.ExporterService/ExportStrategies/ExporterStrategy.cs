using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.ExporterService.ExportStrategies;

public abstract class ExporterStrategy : IExporterStrategy
{
    private string _exportDirectory;

    public ExporterStrategy(string exportDirectory)
    {
        _exportDirectory = exportDirectory;
    }
    
    public CustomFile Export(IList<String> exportData)
    {
        bool exists = System.IO.Directory.Exists(_exportDirectory);

        if(!exists)
            System.IO.Directory.CreateDirectory(_exportDirectory);
        
        var filePath = ConvertStringListToFile(exportData, _exportDirectory);

        var fileBytes = File.ReadAllBytes(filePath);
        
        var result = new CustomFile
        {
            ContentType = "application/octet-stream",
            FileName = filePath,
            FileContents = fileBytes
        };

        return result;
    }

    public abstract string ConvertStringListToFile(IList<String> exportData, string exportDirectory);
}