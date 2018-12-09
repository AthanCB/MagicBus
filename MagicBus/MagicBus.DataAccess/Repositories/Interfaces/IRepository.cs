using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MagicBus.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<ICollection<T>> GetAllAsync();
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        void DeleteById(string id);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
