using AutoMapper;
using HAN.ICDETool.Services.ResponseDtos;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Core.Specifications;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public class LesMateriaalService : BaseEntityService<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto>, ILesMateriaalService
{
    private readonly ILesMateriaalExporter _exporter;
    private readonly IRepository<LesMateriaal> _repository;
    private readonly IMapper _mapper;
        
    public LesMateriaalService(ILesMateriaalExporter exporter, IRepository<LesMateriaal> repository, ILogger<BaseEntityService<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto>> logger, IMapper mapper) : base(repository, logger, mapper)
    {
        _exporter = exporter;
        _repository = repository;
        _mapper = mapper;
    }

    public IEnumerable<LesMateriaalResponseDto> GetByLesId(int lesId)
    {
        var result = _repository.ListAsync(new LesMateriaalByLesId(lesId)).Result;
        return _mapper.Map<List<LesMateriaalResponseDto>>(result);
    }

    public string Export(string formaat, int id)
    {
        LesMateriaal lesMateriaal = _repository.GetByIdAsync(id).Result;
        
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