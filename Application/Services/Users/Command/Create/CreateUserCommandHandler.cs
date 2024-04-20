
using Domain.Etities;
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Users.Command.Create;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
{
    private readonly IUserRepository context;
    public CreateUserCommandHandler(IUserRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = User.Create(request.Name, request.Email, request.Password);
        var IsCreate = await context.Create(user);
        return IsCreate;
    }
}
