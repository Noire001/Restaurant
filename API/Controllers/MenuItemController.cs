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
    
    [Route("categories")]
    public async Task<IActionResult> GetMenuItem()
    {
        return HandleResult(await Mediator.Send(new ListByCategory.Query { }));
    }
}