
using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.OrderItems.Query.GetAll;

public class GetAllOrderItemQueryHandler : IRequestHandler<GetAllOrderItemQuery, List<OrderItem>>
{
    private readonly IOrderItemRepository context;
    public GetAllOrderItemQueryHandler(IOrderItemRepository context)
    {
        this.context = context;
    }

    public async Task<List<OrderItem>> Handle(GetAllOrderItemQuery request, CancellationToken cancellationToken)
    {
        var orderItem = await context.GetAll();
        return orderItem;
    }
}
