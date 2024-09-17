using System;
using Domain;
using Domain.Enums;

namespace Service.Interfaces;

public interface IUserRepo
{
    User CreateUser(User user);
    void DeleteUser(uint userId);
    User Login(string username, string password);
    List<Roles> CheckUserRole(string username);
}
