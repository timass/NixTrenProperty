using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces
{
    public interface IApartmentRepository// : IDisposable
    {
        IEnumerable<Apartment> GetApartmentList();
        Apartment GetApartment(int id);
        void Create(Apartment item);
        void Update(Apartment item);
        void Delete(int id);
        void Save();
        void Dispose();
    }
}
