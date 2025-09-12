using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Platform.Data;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Data.Sequences
{
    public static class ILinksExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSequence<TLinkAddress, TConstants>(this ILinks<TLinkAddress, TConstants> links, TLinkAddress link)
            where TLinkAddress : IUnsignedNumber<TLinkAddress>
            where TConstants : LinksConstants<TLinkAddress>
        {
            var constants = links.Constants;
            if (EqualityComparer<TLinkAddress>.Default.Equals(link, constants.Null) || 
                EqualityComparer<TLinkAddress>.Default.Equals(link, constants.Any))
            {
                return false;
            }
            
            return !links.IsPartialPoint(link);
        }
    }
}