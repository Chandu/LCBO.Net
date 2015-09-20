using Xunit;
using FluentAssertions;

namespace Specs
{
  [Trait("Canary", "True is true")]
  public class CanarySpec
  {
    [Fact]
    public void TrueIsTrue()
    {
      true.Should().Be(true);
    }
  }
}