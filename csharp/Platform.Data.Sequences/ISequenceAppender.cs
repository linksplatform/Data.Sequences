using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Data.Sequences
{
    public interface ISequenceAppender<TLinkAddress>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        TLinkAddress Append(TLinkAddress sequence, TLinkAddress appendant);
    }
}
