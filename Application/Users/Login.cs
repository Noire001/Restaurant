using Application.Core;
using Application.DTOs;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Users;

public class Login
{
    public class Query : IRequest<Result<UserDto>>
    {
        public LoginDto LoginDto { get; init; } = null!;
    }

    public class Handler : IRequestHandler<Query, Result<UserDto>>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenService _tokenService;

        public Handler(UserManager<User> userManager, SignInManager<User> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<Result<UserDto>> Handle(Query request, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == request.LoginDto.Username, cancellationToken);

            if (user == null) return Result<UserDto>.Unauthorized();

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.LoginDto.Password, false);
            var userDto = new UserDto
            {
                Token = _tokenService.CreateToken(user),
                Username = user.UserName,
            };
            if (!result.Succeeded) return Result<UserDto>.Unauthorized();
            
            await _tokenService.SetRefreshToken(user);
            return Result<UserDto>.Success(userDto);
        }
    }
}