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
    public class VehicleCompanyRepository : IVehicleCompanyRepository
    {
        protected SmartDbContext _context;
        public VehicleCompanyRepository(SmartDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(VehicleCompany entity)
        {
            await _context.Set<VehicleCompany>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<VehicleCompany, bool>> predicate)
         => _context.Set<VehicleCompany>().CountAsync(predicate);

        public Task<VehicleCompany> FirstOrDefault(Expression<Func<VehicleCompany, bool>> predicate)
        => _context.Set<VehicleCompany>().FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<VehicleCompany>> GetAll()
        {
            return await _context.Set<VehicleCompany>().ToListAsync();
        }

        public async Task<VehicleCompany> GetById(long id)
        {
            return await _context.Set<VehicleCompany>().FindAsync(id);
        }

        public async Task<IEnumerable<VehicleCompany>> GetWhere(Expression<Func<VehicleCompany, bool>> predicate)
        {
            return await _context.Set<VehicleCompany>().Where(predicate).ToListAsync();
        }

        public Task Remove(VehicleCompany entity)
        {
            _context.Set<VehicleCompany>().Remove(entity);
            return _context.SaveChangesAsync();
        }

        public Task Update(VehicleCompany entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
        public Task<int> _countAll() => _context.Set<VehicleCompany>().CountAsync();
    }
}
