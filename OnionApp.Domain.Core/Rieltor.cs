using System.Collections.Generic;
namespace OnionApp.Domain.Core

{
   public class Rieltor : Seller
    {
        public string Describe { get; set; }      
        public Rieltor(int userId, string name, string parol, string email, string telephone,
            string passport, string describe)
            : base (userId, name, email, parol, telephone, passport)
        {  
            Describe = describe;
        }
    }
}
