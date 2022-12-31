using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.ExporterService.ExportStrategies;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.ExporterService;

public class LesMateriaalExporter : ILesMateriaalExporter
{
    
    public CustomFile ExportLesMateriaal(ExportFormaat formaat, LesMateriaal lesMateriaal)
    { 
       IExporterFactory factory = new ExporterFactory();
        
       factory.ChooseExportType(formaat);
       
       IList<String> lesMateriaalLines = lesMateriaal.Inhoud.Select(e => e.Line).ToList();

       var result = factory.Export(lesMateriaalLines);
       
       return result;
    }
}