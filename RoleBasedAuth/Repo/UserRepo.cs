using System;
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
        throw new NotImplementedException();
    }

    public void CreateUser()
    {
        throw new NotImplementedException();
    }

    public void DeleteUser()
    {
        throw new NotImplementedException();
    }

    public void Login(string username, string password)
    {
        throw new NotImplementedException();
    }
}
