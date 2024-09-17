using System;

namespace Service.Interfaces;

public interface IUserService
{
    void CreateUser();
    void DeleteUser();
    void Login(string username, string password);
}
