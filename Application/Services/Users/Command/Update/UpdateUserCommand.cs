
using Contracts.DTO;
using Domain.Etities;
using MediatR;

namespace Application.Services.Users.Command.Update;

public class UpdateUserCommand : IRequest
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public UpdateUserCommand(UserDTO user)
    {
        UserName = user.UserName;
        Email = user.Email;
        Password = user.Password;
    }
}
