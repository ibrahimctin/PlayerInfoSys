namespace PlayerInfoSys.Domain.Common.Results.Paginations.PagingQueries
{
    public interface IPaginationQuery
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}
