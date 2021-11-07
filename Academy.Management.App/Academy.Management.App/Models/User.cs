using Academy.Management.App.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Models
{
    public class User
    {
        public User() { }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(int id, string fname, string lname, string email, string password, Role role)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Email = email;
            Password = password;
            Role = role;
        }

        public void ValidatePassword(string password)
        {
            if (password != Password)
            {
                throw new Exception("Not valid password");
            }
        }

        public bool IsValidPassword(string password)
        {
            return password == Password;
        }
    }
}
