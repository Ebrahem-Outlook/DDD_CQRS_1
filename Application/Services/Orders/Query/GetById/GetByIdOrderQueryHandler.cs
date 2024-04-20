using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Orders.Query.GetById;

public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQuery, Order>
{
    private readonly IOrderRepository context;
    public GetByIdOrderQueryHandler(IOrderRepository context)
    {
        this.context = context;
    }

    public async Task<Order> Handle(GetByIdOrderQuery request, CancellationToken cancellationToken)
    {
        var user = await context.GetById(request.Id);
        return user;
    }
}
