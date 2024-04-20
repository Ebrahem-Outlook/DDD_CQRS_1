using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Orders.Query.GetAll;

public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQuery, List<Order>>
{
    private readonly IOrderRepository context;
    public GetAllOrderQueryHandler(IOrderRepository context)
    {
        this.context = context;
    }

    public async Task<List<Order>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
    {
        var users = await context.GetAll();
        return users;
    }
}
