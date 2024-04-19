
using Domain.Etities;
using MediatR;

namespace Application.Services.Users.Query.GetByEmail;

public class GetByEmailUserQueryHandler : IRequestHandler<GetByEmailUserQuery, User>
{
    public Task<User> Handle(GetByEmailUserQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
