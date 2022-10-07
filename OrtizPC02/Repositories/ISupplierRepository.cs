using System;
using OrtizPC02.Models;

namespace OrtizPC02.Repositories
{
    public interface ISupplierRepository
    {
        Task<bool> Delete(int id);
        Task<Supplier> GetSupplier(int id);
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<bool> Insert(Supplier supplier);
        Task<bool> Update(Supplier supplier);
    }
}

