using System.Collections.Generic;
using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Data.Sequences
{
    public interface ISequenceWalker<TLinkAddress>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        IEnumerable<IList<TLinkAddress>> Walk(TLinkAddress sequence);
    }
}
