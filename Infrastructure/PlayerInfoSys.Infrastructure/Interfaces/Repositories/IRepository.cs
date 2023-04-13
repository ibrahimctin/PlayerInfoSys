namespace PlayerInfoSys.Infrastructure.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<bool> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);

        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task<T> GetWhere(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllWhere(Expression<Func<T, bool>> expression);

        
        Task<TResult> GetFilteredFirstOrDefault<TResult>(
            Expression<Func<T, TResult>> selector,
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);

     
        Task<List<TResult>> GetFilteredList<TResult>(
            Expression<Func<T, TResult>> selector,
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null,
            int limit = 0);

        Task<bool> ExecuteRawSqlQuery(string query);
        IQueryable<T> GetPaging(Expression<Func<T, bool>> predicate = null, PaginationQuery paginationQuery = null);
    

        Task<int> CountAsync();
    }
}
