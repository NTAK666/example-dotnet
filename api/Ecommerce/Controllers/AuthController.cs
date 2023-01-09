using System.Net;
using AutoMapper;
using CoreApiResponse;
using Ecommerce.Helpers.Interface;
using Ecommerce.Models.Dtos;
using Ecommerce.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers;

[ApiController]
[Route("/api/auth")]
public class AuthController : BaseController
{
    private readonly IUserRepository _repository;
    private readonly IJwtHelper _jwtHelper;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;

    public AuthController(IUserRepository repository, IJwtHelper jwtHelper, IMapper mapper,
        IConfiguration configuration)
    {
        _repository = repository;
        _jwtHelper = jwtHelper;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TokenDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> SignIn([FromBody] SignInDto dto)
    {
        var user = await _repository.FindByEmail(dto.Email);
        if (user == null)
        {
            return CustomResult("Not Found", new[]
            {
                "Email or password invalid"
            }, HttpStatusCode.BadRequest);
        }

        var result = await _repository.SignInAsync(user, dto.Password);

        if (!result.Succeeded)
        {
            return CustomResult("Not Found", new[]
            {
                "Email or password invalid"
            }, HttpStatusCode.BadRequest);
        }

        var tokenDto = await _repository.CreateUserToken(dto.Email);

        return CustomResult("Success", tokenDto);
    }
}