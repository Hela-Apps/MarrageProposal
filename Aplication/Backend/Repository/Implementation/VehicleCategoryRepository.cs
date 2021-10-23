using Entity.Models;
using Entity.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using SmartERP.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class VehicleCategoryRepository :  IVehicleCategoryRepository
    {
        protected SmartDbContext _context;
        public VehicleCategoryRepository(SmartDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(VehicleCategory entity)
        {
            await _context.Set<VehicleCategory>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<VehicleCategory, bool>> predicate)
         => _context.Set<VehicleCategory>().CountAsync(predicate);

        public Task<VehicleCategory> FirstOrDefault(Expression<Func<VehicleCategory, bool>> predicate)
        => _context.Set<VehicleCategory>().FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<VehicleCategory>> GetAll()
        {
            return await _context.Set<VehicleCategory>().ToListAsync();
        }

        public async Task<VehicleCategory> GetById(long id)
        {
            return await _context.Set<VehicleCategory>().FindAsync(id);
        }

        public async Task<IEnumerable<VehicleCategory>> GetWhere(Expression<Func<VehicleCategory, bool>> predicate)
        {
            return await _context.Set<VehicleCategory>().Where(predicate).ToListAsync();
        }

        public Task Remove(VehicleCategory entity)
        {
            _context.Set<VehicleCategory>().Remove(entity);
            return _context.SaveChangesAsync();
        }

        public Task Update(VehicleCategory entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
        public Task<int> _countAll() => _context.Set<VehicleCategory>().CountAsync();
    }
}
