
using MediatR;

namespace Application.Services.Users.Command.Delete;

public class DeleteUserCommand : IRequest
{
    public Guid Id { get; set; }
    public DeleteUserCommand(Guid id) => Id = id;
}
