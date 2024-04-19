using Domain.Etities;
using MediatR;

namespace Application.Services.Users.Query.GetAll;

public class GetAllUsersQuery : IRequest<List<User>>
{
}
