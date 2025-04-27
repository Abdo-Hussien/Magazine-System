using System;

namespace Magazine_System
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string role { get; set; }

        public User() 
        {
            Id = -1;
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Gender = string.Empty;
            CreatedAt = DateTime.MinValue;
            UpdatedAt = DateTime.MinValue;
            role = "user";
        }
        public User(int id, string name, string email, string password, string gender, DateTime createdAt, DateTime updatedAt, string role = "user")
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Gender = gender;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            this.role = role;
        }

    }
}