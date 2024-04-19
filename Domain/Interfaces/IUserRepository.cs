using Domain.Etities;

namespace Domain.Interfaces;

public interface IUserRepository
{
    // Commands
    Task<bool> Create(User user);
    Task<bool> Update(User user);
    Task<bool> Delete(Guid id);

    // Queries 
    Task<List<User>> GetAll();
    Task<User> GetById(Guid id);
    Task<User> GetByEmail(string email);

}
