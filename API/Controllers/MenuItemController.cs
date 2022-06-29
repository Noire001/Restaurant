using Application.MenuItems;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class MenuItemController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetMenuItems()
    {
        return HandleResult(await Mediator.Send(new List.Query { }));
    }
}