using System.Security.Cryptography.Xml;
using ApiAuth.Models;

namespace ApiAuth.Repositories;

public class UserRepository
{
    public static User Get(string username, string password)
    {
        var users = new List<User>
        {
            new() { Id = 1, Username = "Batman", Password = "batman", Role = "manager" },
            new() { Id = 2, Username = "Robin", Password = "robin", Role = "employee" }
        };
        return users
            .FirstOrDefault(x =>
                x.Username == username
                && x.Password == password);
    }
}