
using Domain.Interfaces;
using MediatR;

namespace Application.Services.Users.Command.Delete;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
{
    private readonly IUserRepository context;
    public DeleteUserCommandHandler(IUserRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var IsDelete = await context.Delete(request.Id);
        return IsDelete;
    }
}
