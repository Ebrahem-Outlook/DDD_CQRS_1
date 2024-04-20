using Domain.Etities;
using MediatR;

namespace Application.Services.Orders.Query.GetAll;

public class GetAllOrderQuery : IRequest<List<Order>>
{
}
