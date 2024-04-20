using Contracts.Users;
using MediatR;

namespace Application.Services.Users.Command.Update;

public class UpdateUserCommand : IRequest<bool>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
