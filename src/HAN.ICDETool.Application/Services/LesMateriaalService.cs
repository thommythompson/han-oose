using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Application.Services.Interfaces;
using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Services;

public class LesMateriaalService : ILesMateriaalService
{
    private ILesMateriaalRepository _repository;
    private ILesMateriaalExporter _exporter;

    public LesMateriaalService(ILesMateriaalRepository repository, ILesMateriaalExporter exporter)
    {
        _repository = repository;
        _exporter = exporter;
    }

    public IEnumerable<LesMateriaal> Get()
    {
        return _repository.Get();
    }

    public LesMateriaal GetById(int id)
    {
        return _repository.GetById(id);
    }
    
    public IEnumerable<LesMateriaal> GetByLesId(int lesId)
    {
        return _repository.GetByLesId(lesId);
    }

    public string Export(string formaat, int Id)
    {

        LesMateriaal lesMateriaal = _repository.GetById(Id);
        
        ExportFormaat exportFormaat;
        
        switch (formaat)
        {
            case "csv":
                exportFormaat = ExportFormaat.Csv;
                break;
            case "pdf":
                exportFormaat = ExportFormaat.Pdf;
                break;
            case "docx":
                exportFormaat = ExportFormaat.Docx;
                break;
            default:
                throw new Exception("Invalid export format specified");
        }
        
        return _exporter.ExportLesMateriaal(exportFormaat, lesMateriaal);
    }
}