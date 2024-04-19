using Domain.Etities;
using MediatR;

namespace Application.Services.Users.Query.GetById;

public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, User>
{
    public Task<User> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
