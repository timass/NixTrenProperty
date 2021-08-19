using System;
using System.ComponentModel.DataAnnotations;

namespace OnionApp.Domain.Core
{
    public abstract class User
    {
        //public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfRegistration { get;} = DateTime.Now;
        public string Password { get; set; }
        public User() { }
    }
}
