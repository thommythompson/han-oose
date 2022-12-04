using AutoMapper;
using HAN.ICDETool.Application.Mappings;
using HAN.ICDETool.Services.ResponseDtos;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Core.Specifications;
using HAN.ICDETool.Services.RequestDtos;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public class LesInrichtingService : BaseEntityService<LesInrichting, LesInrichtingRequestDto, LesInrichtingResponseDto>, ILesInrichtingService
{
    private IRepository<LesInrichting> _repository;
    private IMapper _mapper;
    
    public LesInrichtingService(IRepository<LesInrichting> repository, ILogger<BaseEntityService<LesInrichting, LesInrichtingRequestDto, LesInrichtingResponseDto>> logger, IMapper mapper) : base(repository, logger, mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public override async Task<IEnumerable<LesInrichtingResponseDto>> Read()
    {
        var result = await _repository.ListAsync(new LesInrichtingWithReferences());
        return _mapper.Map<List<LesInrichtingResponseDto>>(result);
    }
}