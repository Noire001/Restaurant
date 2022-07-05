using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    private IMediator? _mediator;

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()!;

    protected ActionResult HandleResult<T>(Result<T>? result)
    {
        if (result == null) return NotFound();

        switch (result.ResultStatus)
        {
            case Result<T>.Status.Failure:
                return BadRequest(result.Error);
            case Result<T>.Status.Unauthorized:
                return Unauthorized();
            case Result<T>.Status.ValidationError:
                ModelState.AddModelError("error", result.Error);
                return ValidationProblem();
        }

        if (result.Value != null) return Ok(result.Value);
        return NotFound();
    }
}