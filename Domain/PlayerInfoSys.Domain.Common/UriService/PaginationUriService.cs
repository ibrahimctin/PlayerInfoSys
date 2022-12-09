using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using PlayerInfoSys.Domain.Common.Extensions;
using PlayerInfoSys.Domain.Common.Results.Paginations.PagingQueries;

namespace PlayerInfoSys.Domain.Common.UriService
{
    public class PaginationUriService:IPaginationUriService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public PaginationUriService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public Uri GetPageUri(PaginationQuery paginationQuery)
        {

            var baseUri = httpContextAccessor.GetRequestUri();
            var route = httpContextAccessor.GetRoute();
            var endpoint = new Uri(string.Concat(baseUri, route));
            var queryUri = QueryHelpers.AddQueryString($"{endpoint}", "pageNumber", $"{paginationQuery.PageNumber}");
            queryUri = QueryHelpers.AddQueryString(queryUri, "pageSize", $"{paginationQuery.PageSize}");
            return new Uri(queryUri);
        }
    }
}
