using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Data
{
    public class RepositorioGenerico<T> where T : class
    {
        public readonly ContextoDados _context;

        public RepositorioGenerico(ContextoDados contextData)
        {
            _context = contextData;
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> c)
        {
            if (c == null)
                return null;

            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(c);
        }

        public async Task<T> InsertAsync(T model)
        {
            _context.Set<T>().Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<T> UpdateAsnc(T model)
        {
            _context.Set<T>().Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
        public async Task DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            T? model = await _context.Set<T>().FirstOrDefaultAsync(predicate);

            if (model == null)
                return;

            _context.Set<T>().Remove(model);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T model)
        {
            if (model == null)
                return;

            _context.Set<T>().Remove(model);
            await _context.SaveChangesAsync();
        }

        public async Task<T?> GetByIdAsync(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAsync(Expression<Func<T, bool>>? c = null)
        {
            if (c == null)
                return await _context.Set<T>().AsNoTracking().ToListAsync();
            else
                return await _context.Set<T>().Where(c).AsNoTracking().ToListAsync();
        }

        public async Task<long> CountAsync(Expression<Func<T, bool>> c)
        {
            return await _context.Set<T>().Where(c).AsNoTracking().LongCountAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> c)
        {
            return await _context.Set<T>().AnyAsync(c);
        }
    }
}
