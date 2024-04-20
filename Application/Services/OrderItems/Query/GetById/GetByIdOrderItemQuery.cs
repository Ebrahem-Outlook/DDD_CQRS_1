
using Domain.Etities;
using MediatR;

namespace Application.Services.OrderItems.Query.GetById;

public class GetByIdOrderItemQuery : IRequest<OrderItem>
{
    public Guid Id { get; private set; }

    public GetByIdOrderItemQuery(Guid id) => Id = id;
}
