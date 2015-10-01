using System;

namespace LCBO.Net.Responses
{
  [Flags]
  public enum StoreFeatures:int
  {
    HasBeerColdRoom = 1,
    HasBilingualServices = 2,
    HasParking = 4,
    HasProductConsultant = 8,
    HasSpecialOccasionPermits = 16,
    HasTastingBar = 32,
    HasTransitAccess = 64,
    HasVintagesCorner = 128,
    HasWheelchairAccessability = 256
  }
}