
using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.OrderItems.Query.GetById;

public class GetByIdOrderItemQueryHandler : IRequestHandler<GetByIdOrderItemQuery, OrderItem>
{
    private readonly IOrderItemRepository context;
    public GetByIdOrderItemQueryHandler(IOrderItemRepository context)
    {
        this.context = context;
    }

    public async Task<OrderItem> Handle(GetByIdOrderItemQuery request, CancellationToken cancellationToken)
    {
        var user = await context.GetById(request.Id);
        return user;
    }
}
