using MediatR;

namespace Application.Services.Users.Command.Create;

public class CreateUserCommand : IRequest<bool>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
