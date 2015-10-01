using System;
using System.Collections.Generic;

namespace LCBO.Net.Responses
{
  public class Store
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public StoreAddress Address { get; set; }
    public StoreFeatures Features { get; set; }
    public bool IsDead { get; set; }
    public int ProductsCount { get; set; }
    public IEnumerable<string> Tags { get; set; }
    public DateTime LastUpdatedTime { get; set; }
    public InventoryInformation Inventory { get; set; }
    public IEnumerable<StoreHours> Hours { get; set; }
  }

  public class InventoryInformation
  {
    public int Count { get; set; }
    public long PriceInCents { get; set; }
    public long VolumeInMilliMeters { get; set; }
  }

  public class StoreHours
  {
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan ClosesAt { get; set; }
    public TimeSpan OpensAt { get; set; }
  }
}