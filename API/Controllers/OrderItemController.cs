using Application.Services.OrderItems.Command.Create;
using Application.Services.OrderItems.Command.Delete;
using Application.Services.OrderItems.Command.Update;
using Application.Services.OrderItems.Query.GetAll;
using Application.Services.OrderItems.Query.GetById;
using Contracts.OrderItems;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class OrderItemController : ControllerBase
{
    private readonly IMediator mediator;
    public OrderItemController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await mediator.Send(new GetAllOrderItemQuery()));
    }

    [HttpGet("id")]
    public async Task<IActionResult> GetById(Guid id)
    {
        return Ok(await mediator.Send(new GetByIdOrderItemQuery(id)));
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateOrderItemRequest request)
    {
        var response = await mediator.Send(new CreateOrderItemCommand(request.Name, request.Description, request.Price, request.Quantity));
        if (response)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }

    [HttpPut]
    public async Task<IActionResult> Put(UpdateOrderItemRequest request)
    {
        var response = await mediator.Send(new UpdateOrderItemCommand(request.Id, request.Name, request.Description, request.Price, request.Quantity));

        if (response)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        var response = await mediator.Send(new DeleteOrderItemCommand(id));
        if (response)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }
}
