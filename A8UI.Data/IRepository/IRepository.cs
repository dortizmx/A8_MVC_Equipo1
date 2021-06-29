using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace A8UI.Data.IRepository
{
    public interface IRepository<T>
    {
        public Task<T> Add(T obj, CancellationToken ct = default(CancellationToken));
        public Task<List<T>> GetAll(CancellationToken ct = default(CancellationToken));
        public Task<T> GetById(int id, CancellationToken ct = default(CancellationToken));
        public Task<T> Update(T obj, CancellationToken ct = default(CancellationToken));
        public Task<T> Delete(T obj, CancellationToken ct = default(CancellationToken));


    }
}
