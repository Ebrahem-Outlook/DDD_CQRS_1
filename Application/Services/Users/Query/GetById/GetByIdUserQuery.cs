using Domain.Etities;
using MediatR;

namespace Application.Services.Users.Query.GetById;

public class GetByIdUserQuery : IRequest<User>
{
    public Guid Id { get; set; }
    public GetByIdUserQuery(Guid id) => Id = id;
}
