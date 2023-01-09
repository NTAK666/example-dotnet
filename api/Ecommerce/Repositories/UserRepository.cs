using System.Security.Claims;
using Ecommerce.Helpers.Interface;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;
using Ecommerce.Repositories.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IJwtHelper _jwtHelper;
    private readonly IConfiguration _configuration;

    public UserRepository(UserManager<User> userManager, SignInManager<User> signInManager, IJwtHelper jwtHelper,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _jwtHelper = jwtHelper;
        _configuration = configuration;
    }

    public async Task<User?> FindById(string id)
    {
        return await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<SignInResult> SignInAsync(User user, string password)
    {
        return await _signInManager.CheckPasswordSignInAsync(user, password, false);
    }

    public Task<bool> RevokeAll()
    {
        throw new NotImplementedException();
    }

    public async Task<TokenDto?> CreateUserToken(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null) return null;
        var roles = await _userManager.GetRolesAsync(user) as List<string>;

        var token = _jwtHelper.GenerateToken(user, roles);
        _ = int.TryParse(_configuration["JWT:TokenExpiresMinutes"], out int tokenExpiresTime);

        await _userManager.UpdateAsync(user);

        return new TokenDto
        {
            AccessToken = token,
            TokenExpires = DateTime.Now.AddMinutes(tokenExpiresTime),
        };
    }

    public async Task<User?> FindByEmail(string email)
    {
        return await _userManager.FindByEmailAsync(email);
    }

    public async Task<User?> GetMe(ClaimsPrincipal user)
    {
        try
        {
            var email = user.FindFirstValue(ClaimTypes.Email);

            if (string.IsNullOrEmpty(email))
            {
                return null;
            }

            var getUser = await _userManager.FindByEmailAsync(email);

            return getUser;
        }
        catch
        {
            return null;
        }
    }

    public async Task<bool> UpdateAsync(User user)
    {
        try
        {
            await _userManager.UpdateAsync(user);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<string>?> GetRoleByUser(User user)
    {
        return await _userManager.GetRolesAsync(user) as List<string>;
    }

    public async Task<int> CountAsync()
    {
        return await _userManager.Users.CountAsync();
    }
}