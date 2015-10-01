namespace LCBO.Net
{
  public interface IApiClient
  {
    bool IsAuthenticated { get; }
    IStoresClient Stores { get; }
  }
}