using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Interfaces;

public interface IBeoordelingService : IEntityService<Beoordeling, BeoordelingRequestDto, BeoordelingResponseDto>
{
    public Task<IEnumerable<BeoordelingResponseDto>> ReadByStudentId(string userName,
        CancellationToken cancellationToken);

    public Task<IEnumerable<BeoordelingResponseDto>> ReadByDocentId(string userName,
        CancellationToken cancellationToken);
}