using AutoMapper;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Core.Specifications;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public class CourseInrichtingService : BaseEntityService<CourseInrichting, CourseInrichtingRequestDto, CourseInrichtingResponseDto>, ICourseInrichtingService
{
    private IRepository<CourseInrichting> _courseInrichtingRepo;
    private IRepository<CourseUitvoering> _courseUitvoeringRepo;
    private IMapper _mapper;
    
    public CourseInrichtingService(IRepository<CourseUitvoering> courseUitvoeringRepo, IRepository<CourseInrichting> courseInrichtingRepo, ILogger<BaseEntityService<CourseInrichting, CourseInrichtingRequestDto, CourseInrichtingResponseDto>> logger, IMapper mapper) : base(courseInrichtingRepo, logger, mapper)
    {
        _courseInrichtingRepo = courseInrichtingRepo;
        _courseUitvoeringRepo = courseUitvoeringRepo;
        _mapper = mapper;
    }

    public async Task<CourseUitvoeringResponseDto> StartUitvoering(int id, DateTime dateTime)
    {
        var courseInrichting = await _courseInrichtingRepo.ListAsync(new SingleCourseInrichtingWithReferences(id));

        if (courseInrichting == null)
        {
            throw new KeyNotFoundException("Courseinrichting not found");
        }
        
        var courseUitvoering = courseInrichting.First().StartCourseUitvoering(dateTime);
        await _courseUitvoeringRepo.AddAsync(courseUitvoering);
        await _courseUitvoeringRepo.SaveChangesAsync();
        
        var courseUitvoeringWithChilds = await _courseUitvoeringRepo.ListAsync(new SingleCourseUitvoeringWithReferences(courseUitvoering.Id));
        return _mapper.Map<CourseUitvoeringResponseDto>(courseUitvoeringWithChilds.First());
    }
}