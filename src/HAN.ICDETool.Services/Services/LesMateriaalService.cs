using AutoMapper;
using HAN.ICDETool.Services.Dtos;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Core.Specifications;
using HAN.ICDETool.Core.Entities;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public class LesMateriaalService : BaseEntityService<LesMateriaal, LesMateriaalDto>, ILesMateriaalService
{
    private readonly ILesMateriaalExporter _exporter;
    private readonly IRepository<LesMateriaal> _repository;
    
    public LesMateriaalService(ILesMateriaalExporter exporter, IRepository<LesMateriaal> repository, ILogger<BaseEntityService<LesMateriaal, LesMateriaalDto>> logger, IMapper mapper) : base(repository, logger, mapper)
    {
        _exporter = exporter;
        _repository = repository;
    }

    public IEnumerable<LesMateriaal> GetByLesId(int lesId)
    {
        return _repository.ListAsync(new LesMateriaalByLesId(lesId)).Result;
    }

    public string Export(string formaat, int id)
    {
        LesMateriaal lesMateriaal = base.Read(id).Result;
        
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