namespace LCBO.Net.Requests
{
  public class SearchRequestBase<TRequest> where TRequest : class
  {
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public TRequest Request { get; set; }
  }
}