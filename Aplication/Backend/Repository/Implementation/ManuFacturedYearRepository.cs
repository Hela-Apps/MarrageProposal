using Entity.Context;
using Entity.Models;
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
    public class ManuFacturedYearRepository : IManuFacturedYearRepository
    {
        protected SmartDbContext _context;
        public ManuFacturedYearRepository(SmartDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(ManuFacturedYear entity)
        {
            await _context.Set<ManuFacturedYear>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<ManuFacturedYear, bool>> predicate)
         => _context.Set<ManuFacturedYear>().CountAsync(predicate);

        public Task<ManuFacturedYear> FirstOrDefault(Expression<Func<ManuFacturedYear, bool>> predicate)
        => _context.Set<ManuFacturedYear>().FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<ManuFacturedYear>> GetAll()
        {
            return await _context.Set<ManuFacturedYear>().ToListAsync();
        }

        public async Task<ManuFacturedYear> GetById(long id)
        {
            return await _context.Set<ManuFacturedYear>().FindAsync(id);
        }

        public async Task<IEnumerable<ManuFacturedYear>> GetWhere(Expression<Func<ManuFacturedYear, bool>> predicate)
        {
            return await _context.Set<ManuFacturedYear>().Where(predicate).ToListAsync();
        }

        public Task Remove(ManuFacturedYear entity)
        {
            _context.Set<ManuFacturedYear>().Remove(entity);
            return _context.SaveChangesAsync();
        }

        public Task Update(ManuFacturedYear entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
        public Task<int> _countAll() => _context.Set<ManuFacturedYear>().CountAsync();
    }
}
