using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperGenericRepository.DAL
{
    public interface IGenericRepository<T>
    {

        Task<IEnumerable<T>> GetAllAsync();
        Task DeleteRowAsync(object id);
        Task<T> GetAsync(object id);
        Task<int> SaveRangeAsync(IEnumerable<T> list);
        Task UpdateAsync(T t);
        Task InsertAsync(T t);



        IEnumerable<T> GetAll();
        void Delete(object id);
        T GetById(object id);
        void Update(T t);
        object Insert(T t);
        int SaveRange(IEnumerable<T> list);

    }
}
