using Domain.Enums;

namespace Domain
{
    public class User
    {
        public required uint Id { get; set; }
        public required string Username { get; set; }
        public required List<Roles> Roles { get; set; }
        public string? Password_Hashed { get; set; }
    }

    public class UserDTO
    {
        public required uint Id { get; set; }
        public required string Username { get; set; } = string.Empty;
    }
}
