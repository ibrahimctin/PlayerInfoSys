namespace PlayerInfoSys.Infrastructure.Implementation.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public Repository(AppDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await _table.AnyAsync(expression);
        }

        public async  Task<int> CountAsync()
        {
             return await _table.CountAsync();
        }

        public async Task<bool> CreateAsync(T entity)
        {
           var TCreate =  await _table.AddAsync(entity);

           return TCreate is null ? false : true;

        }

        public async  Task<bool> DeleteAsync(T entity)
        {
            var TDelete = _table.Remove(entity);

            return TDelete is null ? false : true;



        }

        public async Task<bool> ExecuteRawSqlQuery(string query)
        {
            var TQuery = await _context.Database.ExecuteSqlRawAsync(query);

            return TQuery > 0 ? true : false;
        }

        public IQueryable<T> GetPaging(Expression<Func<T, bool>> predicate = null, PaginationQuery paginationQuery = null)
        {
            var query = _table.AsQueryable();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (paginationQuery != null)
            {
                var skip = (paginationQuery.PageNumber - 1) * paginationQuery.PageSize;
                query = query.Skip(skip).Take(paginationQuery.PageSize);
            }

            return query.AsNoTracking();
        }

        public async Task<List<T>> GetAllWhere(Expression<Func<T, bool>> expression)
        {
            return await _table.Where(expression).ToListAsync();
        }

       

        public async Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null) query = includes(query);
            if (expression != null) query = query.Where(expression);
            if (orderBy != null) return await orderBy(query).Select(selector).FirstOrDefaultAsync();
            else return await query.Select(selector).FirstOrDefaultAsync();
        }

        public async Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null, int limit = 0)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null) query = includes(query);
            if (expression != null) query = query.Where(expression);
            if (orderBy != null) query = orderBy(query);
            if (limit > 0) return await query.Select(selector).Take(limit).ToListAsync();
            else return await query.Select(selector).ToListAsync();
        }

        public async Task<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return await _table.FirstOrDefaultAsync(expression);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            var TUpdate = _table.Update(entity);

            return TUpdate is null ? false : true;


        }
    }
}
