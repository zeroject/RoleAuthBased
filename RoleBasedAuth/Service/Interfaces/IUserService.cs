using System;
using Domain;

namespace Service.Interfaces;

public interface IUserService
{
    User CreateUser(User user);
    void DeleteUser(uint userId);
    void Login(string username, string password);
}
