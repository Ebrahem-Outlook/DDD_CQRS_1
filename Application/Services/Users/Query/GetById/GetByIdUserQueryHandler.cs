using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Users.Query.GetById;

public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, User>
{
    private readonly IUserRepository context;
    public GetByIdUserQueryHandler(IUserRepository context)
    {
        this.context = context;
    }

    public Task<User> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
    {
        var user = context.GetById(request.Id);
        return user;
    }
}
