using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Interfaces;

public interface IAccountService
{
    public Task<TokenResponseDto> CreateToken(TokenRequestDto tokenRequestDto);
}