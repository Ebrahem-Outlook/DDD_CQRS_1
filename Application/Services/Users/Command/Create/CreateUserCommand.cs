
using MediatR;

namespace Application.Services.Users.Command.Create;

public class CreateUserCommand : IRequest
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public CreateUserCommand(string userName, string email, string password)
    {
        UserName = userName;
        Password = password;
        Email = email;
    }
}
