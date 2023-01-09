using System.Net;
using System.Security.Claims;
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
    private readonly IFileHelper _fileHelper;

    public AuthController(IUserRepository repository, IJwtHelper jwtHelper, IMapper mapper,
        IConfiguration configuration, IFileHelper fileHelper)
    {
        _repository = repository;
        _jwtHelper = jwtHelper;
        _mapper = mapper;
        _configuration = configuration;
        _fileHelper = fileHelper;
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

    [HttpPut("update-profile")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> UpdateProfile([FromBody] UserUpdate dto)
    {
        var userId = this.User.FindFirstValue("UserId");
        var user = await _repository.FindById(userId);

        if (user == null) return CustomResult("Failed", HttpStatusCode.BadRequest);

        user.Bio = dto.Bio ?? user.Bio;
        user.FullName = dto.FullName ?? user.FullName;
        user.Address = dto.Address ?? user.Address;

        await _repository.UpdateAsync(user);

        return CustomResult("Success", _mapper.Map<UserDto>(user));
    }

    [HttpGet("me")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> GetMe()
    {
        var userId = this.User.FindFirstValue("UserId");
        var user = await _repository.FindById(userId);

        return user == null ? CustomResult("Failed", HttpStatusCode.BadRequest) : CustomResult("Success", _mapper.Map<UserDto>(user));
    }

    [HttpPost("update-avatar")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> UpdateAvatar([FromForm] UploadFileDto dto)
    {
        var user = await _repository.FindById(this.User.FindFirstValue("UserId"));
        if (user == null) return CustomResult("Not Found", HttpStatusCode.BadRequest);
        
        if (dto.Files.Count > 1)
            return CustomResult("Failed", new[] { "Background can only be 1 file" });
        var avatar = (await _fileHelper.Store(dto.Files))[0];

        user.Avatar = avatar ?? user.Avatar;

        await _repository.UpdateAsync(user);

        return CustomResult("Success", _mapper.Map<UserDto>(user));
    }
}