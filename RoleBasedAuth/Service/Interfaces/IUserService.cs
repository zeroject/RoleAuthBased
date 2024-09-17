using System;
using Domain;

namespace Service.Interfaces;

public interface IUserService
{
    User CreateUser(User user);
    void DeleteUser(uint userId);
    User Login(string username, string password);
}
