namespace HAN.ICDETool.Services.ResponseDtos;

public class TokenResponseDto
{
    public string Token { get; init; }
    public DateTimeOffset Expiration { get; init; }
}