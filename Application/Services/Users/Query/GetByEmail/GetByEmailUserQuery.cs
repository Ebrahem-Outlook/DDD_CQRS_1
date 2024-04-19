using Domain.Etities;
using MediatR;

namespace Application.Services.Users.Query.GetByEmail;

public class GetByEmailUserQuery : IRequest<User>
{
    public string Email { get; set; }
    public GetByEmailUserQuery(string email) => Email = email;
}
