using Application.Services.Users.Command.Create;
using Application.Services.Users.Command.Delete;
using Application.Services.Users.Command.Update;
using Application.Services.Users.Query.GetAll;
using Application.Services.Users.Query.GetByEmail;
using Application.Services.Users.Query.GetById;
using Contracts.DTO;
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        return Ok(await mediator.Send(new GetByIdUserQuery(id)));
    }

    [HttpGet]
    public async Task<IActionResult> GetByEmail(string email)
    {
        return Ok(await mediator.Send(new GetByEmailUserQuery(email)));
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserDTO user)
    {
        await mediator.Send(new CreateUserCommand(user));
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Put(UserDTO user)
    {
        await mediator.Send(new UpdateUserCommand(user));
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        await mediator.Send(new DeleteUserCommand(id));
        return Ok();
    }
}
