
using Domain.Etities;
using MediatR;

namespace Application.Services.OrderItems.Query.GetAll;

public class GetAllOrderItemQuery : IRequest<List<OrderItem>>
{

}
