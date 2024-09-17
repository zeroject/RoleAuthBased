using System;
using Domain;
using Service.Interfaces;

namespace Service;

public class UserService : IUserService
{
    private readonly IUserRepo _userRepo;
    public UserService(IUserRepo userRepo)
    {
        _userRepo = userRepo;
    }

    public User CreateUser(User user)
    {
        return _userRepo.CreateUser(user);
    }

    public void DeleteUser(uint userId)
    {
        _userRepo.DeleteUser(userId);
    }

    public User Login(string username, string password)
    {
        return _userRepo.Login(username, password);
    }
}
