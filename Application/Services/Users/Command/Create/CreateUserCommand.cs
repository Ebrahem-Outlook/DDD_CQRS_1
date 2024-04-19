using Contracts.DTO;
using Domain.Etities;
using MediatR;

namespace Application.Services.Users.Command.Create;

public class CreateUserCommand : IRequest
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public CreateUserCommand(UserDTO userDTO)
    {
        UserName = userDTO.UserName;
        Password = userDTO.Email;
        Email = userDTO.Password ;
    }

    User user = User.Create(UserName);
}
