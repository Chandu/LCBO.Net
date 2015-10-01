using Xunit;
using FluentAssertions;

namespace Specs
{
  [Trait("Canary", "1 == 1")]
  public class CanarySpec
  {
    [Fact(DisplayName ="Should be true.")]
    public void TrueIsTrue()
    {
      true.Should().Be(true);
    }
  }
}