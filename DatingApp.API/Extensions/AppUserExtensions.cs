using DatingApp.API.DTOs;
using DatingApp.API.Entities;
using DatingApp.API.Interfaces;

namespace DatingApp.API.Extensions;

public static class AppUserExtensions
{
    public static UserDto ToDto(this AppUser user, ITokenService tokenServoce)
    {
        return new UserDto
        {
            Id = user.Id,
            Email = user.Email,
            DisplayName = user.DisplayName,
            Token = tokenServoce.CreateToken(user)
        };
    }
}
