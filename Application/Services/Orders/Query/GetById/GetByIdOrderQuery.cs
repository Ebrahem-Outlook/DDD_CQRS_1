using Domain.Etities;
using MediatR;

namespace Application.Services.Orders.Query.GetById;

public class GetByIdOrderQuery : IRequest<Order>
{
    public Guid Id { get; private set; }

    public GetByIdOrderQuery(Guid id) => Id = id;
}
