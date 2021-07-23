using System;
using System.Collections.Generic;
using System.Linq;
using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace OnionApp.Infrastructure.Data
{
    class ApartmentRepository : IApartmentRepository
    {
         
        private AddAdvertContext db;

        public ApartmentRepository()
        {
            this.db = new AddAdvertContext();
        }

        public IEnumerable<Apartment> GetBookList()
        {
            return db.Apartments.ToList();
        }

        public Apartment GetBook(int id)
        {
            return db.Apartments.Find(id);
        }

        public void Create(Apartment apart)
        {
            db.Apartments.Add(apart);
        }

        public void Update(Apartment apart)
        {
            db.Entry(apart).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
           Apartment apart = db.Apartments.Find(id);
            if (apart != null)
                db.Apartments.Remove(apart);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}

