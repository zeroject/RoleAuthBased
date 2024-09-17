using Domain;
using Domain.Enums;
using Service.Interfaces;

namespace Repo;

public class UserRepo : IUserRepo
{
    private readonly DBContext _dbContext;

    public UserRepo(DBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Roles> CheckUserRole(string username)
    {
        User? user = _dbContext.User.FirstOrDefault(u => u.Username == username);
        if (user != null)
        {
            return user.Roles;
        }
        throw new Exception("User not found");
        
    }

    public User CreateUser(User user)
    {
        _dbContext.User.Add(user);
        _dbContext.SaveChanges();

        return user;
    }

    public void DeleteUser(uint userId)
    {
        User? user = _dbContext.User.Find(userId);
        if (user != null)
        {
            _dbContext.User.Remove(user);
            _dbContext.SaveChanges();
        }
    }

    public User Login(string username, string password)
    {
        User user = _dbContext.User.FirstOrDefault(u => u.Username == username);
        if (user != null && user.Password_Hashed == password)
        {
            return user;
        }
        throw new Exception("User not found");
    }
}
