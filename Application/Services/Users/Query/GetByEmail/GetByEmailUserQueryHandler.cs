
using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Users.Query.GetByEmail;

public class GetByEmailUserQueryHandler : IRequestHandler<GetByEmailUserQuery, User>
{
    private readonly IUserRepository context;
    public GetByEmailUserQueryHandler(IUserRepository context)
    {
        this.context = context;
    }

    public async Task<User> Handle(GetByEmailUserQuery request, CancellationToken cancellationToken)
    {
        var user = await context.GetByEmail(request.Email);
        return user;    
    }
}
