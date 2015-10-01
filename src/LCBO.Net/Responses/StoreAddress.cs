namespace LCBO.Net.Responses
{
  public class StoreAddress
  {
    public string FirstLine { get; set; }
    public string SecondLine { get; set; }
    public string City { get; set; }
    public string Fax { get; set; }
    public string Telephone { get; set; }
    public string PostalCode { get; set; }
    public decimal Latitute { get; set; }
    public decimal Longitude { get; set; }
  }
}