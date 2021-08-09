using System;

namespace OnionApp.Domain.Core
{
    public abstract class User
    {
        public int UserId { get; set; } = 0;
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfRegistration { get;} = DateTime.Now;
        public string Parol { get; set; }        
    }
}
