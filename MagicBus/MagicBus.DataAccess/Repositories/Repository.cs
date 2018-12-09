using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MagicBus.Common.Models;
using MagicBus.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MagicBus.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel, new()
    {
        protected MagicContext _context { get; set; }

        public Repository(MagicContext context)
        {
            _context = context;
        }

        public Task<ICollection<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
