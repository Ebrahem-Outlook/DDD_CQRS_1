namespace Domain.Etities;
public class User : IEquatable<User?>
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;

    private User() { }

    private User(string name, string email, string password)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Password = password;
    }

    public static User Create(string name, string email, string password)
    {
        var user = new User(name, email, password);
        if(user is User)
        {
            return user;
        }
        throw new ArgumentNullException();
    }

    public void UpdateName(string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException();
        }
        Name = name;
    }

    public void UpdateEmail(string email)
    {
        if (email is null)
        {
            throw new ArgumentNullException();
        }
        Email = email;
    }

    public void UpdatePassword(string password)
    {
        if (password is null)
        {
            throw new ArgumentNullException();
        }
        Password = password;
    }
    

    public override bool Equals(object? obj)
    {
        return Equals(obj as User);
    }

    public bool Equals(User? other)
    {
        return other is not null &&
               Id.Equals(other.Id) &&
               Name == other.Name &&
               Email == other.Email &&
               Password == other.Password;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Email, Password);
    }

    public static bool operator ==(User? left, User? right)
    {
        return EqualityComparer<User>.Default.Equals(left, right);
    }

    public static bool operator !=(User? left, User? right)
    {
        return !(left == right);
    }
}
