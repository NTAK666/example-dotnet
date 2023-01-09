using System.Security.Claims;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Repositories.Interface;

public interface IUserRepository
{
    // public Task<IdentityResult> SignUpAsync(SignUpDto dto);
    public Task<SignInResult> SignInAsync(User user, string password);
    public Task<bool> RevokeAll();
    public Task<TokenDto?> CreateUserToken(string email);
    public Task<User?> FindByEmail(string email);
    public Task<User?> FindById(string id);
    public Task<User?> GetMe(ClaimsPrincipal user);
    public Task<bool> UpdateAsync(User user);
    public Task<List<string>?> GetRoleByUser(User user);
    public Task<int> CountAsync();

}