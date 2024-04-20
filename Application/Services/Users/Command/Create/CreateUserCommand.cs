using MediatR;

namespace Application.Services.Users.Command.Create;

public class CreateUserCommand : IRequest<bool>
{
    public string Name { get; private set; } 
    public string Email { get; private set; }
    public string Password { get; private set; }

    public CreateUserCommand(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }
}
