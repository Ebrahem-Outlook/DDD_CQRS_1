
using MediatR;

namespace Application.Services.Users.Command.Update;

public class UpdateUserCommand : IRequest
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public UpdateUserCommand(string userName, string email, string password)
    {
        UserName = userName;
        Email = email;
        Password = password;
    }
}
