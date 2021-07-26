using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
   public abstract class User : IDelete
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfRegistration { get; set; } = DateTime.Now;
    }
}
