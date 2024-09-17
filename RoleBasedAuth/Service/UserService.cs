using System;
using Service.Interfaces;

namespace Service;

public class UserService : IUserService
{
    private readonly IUserRepo _userRepo;
    public UserService(IUserRepo userRepo)
    {
        _userRepo = userRepo;
    }

    public void CreateUser()
    {
        _userRepo.CreateUser();
    }

    public void DeleteUser()
    {
        _userRepo.DeleteUser();
    }

    public void Login(string username, string password)
    {
        _userRepo.Login(username, password);
    }
}
