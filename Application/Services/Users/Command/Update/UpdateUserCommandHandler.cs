using Domain.Interfaces;
using MediatR;

namespace Application.Services.Users.Command.Update;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
{
    private readonly IUserRepository context;
    public UpdateUserCommandHandler(IUserRepository context)
    {
        this.context = context;
    }

    public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var user = await context.GetById(request.Id);
            if (user == null || request == null)
            {
                throw new NullReferenceException();
            }
            user.UpdateName(request.Name);
            user.UpdateEmail(request.Email);
            user.UpdatePassword(request.Password);

            var IUpdate = await context.Update(user);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
