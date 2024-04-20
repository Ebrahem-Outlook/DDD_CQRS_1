using Application.Services.Users.Command.Create;
using Application.Services.Users.Command.Delete;
using Application.Services.Users.Command.Update;
using Application.Services.Users.Query.GetAll;
using Application.Services.Users.Query.GetByEmail;
using Application.Services.Users.Query.GetById;
using Contracts.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IMediator mediator;
    public UserController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new GetAllUsersQuery()));
    }

    [HttpGet("id")]
    public async Task<IActionResult> GetById(Guid id)
    {
        return Ok(await mediator.Send(new GetByIdUserQuery(id)));
    }

    [HttpGet("email")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        return Ok(await mediator.Send(new GetByEmailUserQuery(email)));
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateUserRequest user)
    {
        var IsCreated = await mediator.Send(new CreateUserCommand(user.Name, user.Email, user.Password));
        if (IsCreated)
        {
            return Ok();
        }
        return BadRequest();
    }

    [HttpPut]
    public async Task<IActionResult> Put(UpdateUserRequest user)
    {
        var IsDelete = await mediator.Send(new UpdateUserCommand(user.Id, user.Name, user.Email, user.Password));
        if (IsDelete)
        {
            return Ok();
        }
        return BadRequest();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        var IsDelete = await mediator.Send(new DeleteUserCommand(id));
        if (IsDelete)
        {
            return Ok();
        }
        return NotFound();
    }
}
