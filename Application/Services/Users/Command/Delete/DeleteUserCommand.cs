
using MediatR;

namespace Application.Services.Users.Command.Delete;

public class DeleteUserCommand : IRequest<bool>
{
    public Guid Id { get; private set; }
    public DeleteUserCommand(Guid id) => Id = id;
}
