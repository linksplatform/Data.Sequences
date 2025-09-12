using Xunit;
using Platform.Data.Sequences;

namespace Platform.Data.Sequences.Tests
{
    public class ILinksExtensionsTests
    {
        [Fact]
        public void ILinksExtensionsClassExists()
        {
            Assert.True(typeof(ILinksExtensions).IsClass);
            Assert.True(typeof(ILinksExtensions).IsAbstract);
            Assert.True(typeof(ILinksExtensions).IsSealed);
        }
    }
}