using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[AllowAnonymous]
public class AccountController : ControllerBase
{
    private readonly ILogger<AccountController> _logger;
    private readonly IAccountService _accountService;

    public AccountController(
        ILogger<AccountController> logger, 
        IAccountService accountService
    )
    {
        _logger = logger;
        _accountService = accountService;
    }
    
    [HttpPost]
    [Route("CreateToken")]
    public async Task<IActionResult> CreateToken([FromBody]TokenRequestDto tokenRequestDto)
    {
        if (ModelState.IsValid)
        {
            try
            {
                var token = await _accountService.CreateToken(tokenRequestDto);
                return Created("", token);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Login for user {tokenRequestDto.Username} did not succeed.");
                return BadRequest("Helaas, het inloggen is mislukt, controleer je inloggegevens.");
            }
        }
        return BadRequest();
    }
}