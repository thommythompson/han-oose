using AutoMapper;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Core.Specifications;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public class BeoordelingService : BaseEntityService<Beoordeling, BeoordelingRequestDto, BeoordelingResponseDto>, IBeoordelingService
{
    private IRepository<Beoordeling> _repository;
    private IMapper _mapper;
    private UserManager<Persoon> _userManager;

    public BeoordelingService(IRepository<Beoordeling> repository, ILogger<BaseEntityService<Beoordeling, BeoordelingRequestDto, BeoordelingResponseDto>> logger, IMapper mapper, UserManager<Persoon> userManager) : base(repository, logger, mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _userManager = userManager;
    }
    
    public async Task<IEnumerable<BeoordelingResponseDto>> ReadByStudentId(string userName ,CancellationToken cancellationToken)
    {
        var userId = GetUserIdByUserName(userName);
        
        var result = await _repository.ListAsync(new BeoordelingByStudentId(userId));
        return _mapper.Map<List<BeoordelingResponseDto>>(result);
    }
    
    public async Task<IEnumerable<BeoordelingResponseDto>> ReadByDocentId(string userName ,CancellationToken cancellationToken)
    {
        var userId = GetUserIdByUserName(userName);
        
        var result = await _repository.ListAsync(new BeoordelingByDocentId(userId));
        return _mapper.Map<List<BeoordelingResponseDto>>(result);
    }

    private int GetUserIdByUserName(string userName)
    {
        return _userManager.Users.Where(u => u.UserName == userName)
            .Select(u => u.Id).FirstOrDefault();
    }
}