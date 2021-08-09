using System.Collections.Generic;
using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces
{
   public interface IUserRepository<U> where U : User
        {
            IEnumerable<U> GetUserList();
            U GetObjectS(int id);
            void Create(U item);
            void Update(U item);
            void Delete(int id);
            void Save();
            void Dispose();
        }
 }

