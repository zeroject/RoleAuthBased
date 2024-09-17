using System;
using Domain.Enums;

namespace Service.Interfaces;

public interface IUserRepo
{
    void CreateUser();
    void DeleteUser();
    void Login(string username, string password);
    List<Roles> CheckUserRole(string username);
}
