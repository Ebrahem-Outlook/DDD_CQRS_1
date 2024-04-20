using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Users.Query.GetAll;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
{
    private readonly IUserRepository context;
    public GetAllUsersQueryHandler(IUserRepository context)
    {
        this.context = context;
    }

    public Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = context.GetAll();
        return users ;
    }
}
