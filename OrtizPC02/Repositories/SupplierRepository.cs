using System;
using OrtizPC02.Models;
using Microsoft.EntityFrameworkCore;

namespace OrtizPC02.Repositories
{
    public class SupplierRepository: ISupplierRepository
    {
        private readonly SalesContext _context;

        public SupplierRepository(SalesContext context)
        {
            _context = context;
        }

        //READ ALL
        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await _context.Supplier.ToListAsync();
        }

        //READ ONE
        public async Task<Supplier> GetSupplier(int id)
        {
            return await _context.Supplier.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> Insert(Supplier supplier)
        {
            await _context.Supplier.AddAsync(supplier);
            var countRowsAffected = await _context.SaveChangesAsync();
            return countRowsAffected > 0;
        }

        public async Task<bool> Update(Supplier supplier)
        {
            _context.Supplier.Update(supplier);
            var countRowsAffected = await _context.SaveChangesAsync();
            return countRowsAffected > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier == null) return false;
            else
            {
                _context.Supplier.Remove(supplier);
                var countRowsAffected = await _context.SaveChangesAsync();
                return countRowsAffected > 0;
            }
        }
    }
}

