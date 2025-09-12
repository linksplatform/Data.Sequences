using Xunit;
using Platform.Data.Sequences;

namespace Platform.Data.Sequences.Tests
{
    public class SequenceTypeTests
    {
        [Fact]
        public void SequenceTypeClassExists()
        {
            Assert.True(typeof(SequenceType<ulong>).IsClass);
            Assert.True(typeof(SequenceType<ulong>).IsAbstract);
            Assert.True(typeof(SequenceType<ulong>).IsSealed);
        }
    }
}