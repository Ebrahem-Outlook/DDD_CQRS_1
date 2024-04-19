using Domain.Etities;
using MediatR;

namespace Application.Services.Users.Query.GetAll;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
{
    public Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
