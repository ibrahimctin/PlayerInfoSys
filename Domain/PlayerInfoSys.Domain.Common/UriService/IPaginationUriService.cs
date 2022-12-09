using PlayerInfoSys.Domain.Common.Results.Paginations.PagingQueries;

namespace PlayerInfoSys.Domain.Common.UriService
{
    public interface IPaginationUriService
    {
       public Uri GetPageUri (PaginationQuery paginationQuery);
    }
}
