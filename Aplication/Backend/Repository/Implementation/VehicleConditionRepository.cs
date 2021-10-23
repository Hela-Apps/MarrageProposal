using Entity.Models;
using Entity.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class VehicleConditionRepository : IVehicleConditionRepository
    {
        protected SmartDbContext _context;
        public VehicleConditionRepository(SmartDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(VehicleCondition entity)
        {
            await _context.Set<VehicleCondition>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<VehicleCondition, bool>> predicate)
         => _context.Set<VehicleCondition>().CountAsync(predicate);

        public Task<VehicleCondition> FirstOrDefault(Expression<Func<VehicleCondition, bool>> predicate)
        => _context.Set<VehicleCondition>().FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<VehicleCondition>> GetAll()
        {
            return await _context.Set<VehicleCondition>().ToListAsync();
        }

        public async Task<VehicleCondition> GetById(long id)
        {
            return await _context.Set<VehicleCondition>().FindAsync(id);
        }

        public async Task<IEnumerable<VehicleCondition>> GetWhere(Expression<Func<VehicleCondition, bool>> predicate)
        {
            return await _context.Set<VehicleCondition>().Where(predicate).ToListAsync();
        }

        public Task Remove(VehicleCondition entity)
        {
            _context.Set<VehicleCondition>().Remove(entity);
            return _context.SaveChangesAsync();
        }

        public Task Update(VehicleCondition entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
        public Task<int> _countAll() => _context.Set<VehicleCondition>().CountAsync();
    }
}
