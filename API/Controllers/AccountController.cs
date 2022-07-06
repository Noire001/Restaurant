using Application.DTOs;
using Application.Users;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AccountController : BaseApiController
{
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        return HandleResult(await Mediator.Send(new Login.Query {LoginDto = loginDto}));
    }
}