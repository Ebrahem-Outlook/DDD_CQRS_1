using Domain.Etities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext context;

    public UserRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<bool> Create(User user)
    {
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(Guid Id)
    {
        var user = await context.Users.FindAsync(Id);
        if(user is null)
        {
            return false;
        }

        context.Remove(user);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<List<User>> GetAll()
    {
        var users = await context.Users.ToListAsync();
        if(users is null)
        {
            throw new NullReferenceException();
        }
        return users;
    }

    public async Task<User> GetByEmail(string email)
    {
        var user = await context.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (user is null)
        {
            throw new NullReferenceException();
        }
        return user;
    }

    public async Task<User> GetById(Guid id)
    {
        var user = await context.Users.FindAsync(id);
        if (user is null)
        {
            throw new NullReferenceException();
        }
        return user;
    }

    public async Task<bool> Update(User user)
    {
        var entity = await context.Users.FindAsync(user.Id);
        if(entity is null)
        {
            throw new NullReferenceException();
        }

        try
        {
            entity.UpdateName(user.Name);
            entity.UpdateEmail(user.Email);
            entity.UpdatePassword(user.Password);
            await context.SaveChangesAsync();
            return true;
        }
        catch (ArgumentNullException)
        {
            return false;
        }
    }
}
