using System.Collections.Generic;
using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces
{
    public interface  IObjectSRepository<O>  where O : ObjectS
    {
        IEnumerable<O> GetObjectList();
        O GetObject(int id);
        void Create(O item);
        void Update(O item);
        void Delete(int id);
        void Save();
        void Dispose();
    }
}
