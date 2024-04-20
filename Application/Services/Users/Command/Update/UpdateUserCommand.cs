using Contracts.Users;
using MediatR;

namespace Application.Services.Users.Command.Update;

public class UpdateUserCommand : IRequest<bool>
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } 
    public string Email { get; private set; } 
    public string Password { get; private set; }

    public UpdateUserCommand(Guid id, string name, string email, string password)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
    }
}
