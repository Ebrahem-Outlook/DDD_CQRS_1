using Application.Services.Orders.Command.Create;
using Application.Services.Orders.Command.Delete;
using Application.Services.Orders.Command.Update;
using Application.Services.Orders.Query.GetAll;
using Application.Services.Orders.Query.GetById;
using Contracts.Orders;
using Domain.Etities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IMediator mediator;
    public OrderController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new GetAllOrderQuery()));
    }

    [HttpGet("id")]
    public async Task<IActionResult> GetById(Guid id)
    {
        return Ok(await mediator.Send(new GetByIdOrderQuery(id)));
    }

    [HttpPost]
    public async Task<IActionResult> Post(Order request)
    {
        var IsCreate = await mediator.Send(new CreateOrderCommand(request.Name, request.OrderItems));
        if (IsCreate)
        {
            return Ok();
        }
        return BadRequest(); 
    }

    [HttpPut]
    public async Task<IActionResult> Put(UpdateOrderRequest request)
    {
        var IsUpdate = await mediator.Send(new UpdateOrderCommand(request.Id, request.Name, request.OrderItemRequest));
        if (IsUpdate)
        {
            return Ok();
        }
        return BadRequest();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        var IsDelete = await mediator.Send(new DeleteOrderCommand(id));
        if (IsDelete)
        {
            return Ok();
        }
        return BadRequest();
    }
}
