
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Users.Command.Create;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
{
    private readonly IUserRepository context;
    public CreateUserCommandHandler(IUserRepository context)
    {
        this.context = context;
    }

    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        await context.Create(request);
    }
}
