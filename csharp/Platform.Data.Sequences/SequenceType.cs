using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Platform.Data;
using Platform.Delegates;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Data.Sequences
{
    public static class SequenceType<TLinkAddress>
        where TLinkAddress : IUnsignedNumber<TLinkAddress>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TLinkAddress GetOrCreate<TConstants>(ILinks<TLinkAddress, TConstants> links)
            where TConstants : LinksConstants<TLinkAddress>
        {
            var constants = links.Constants;
            var existingLink = constants.Null;
            ReadHandler<TLinkAddress> handler = link =>
            {
                if (link != null)
                {
                    existingLink = link[constants.IndexPart];
                }
                return constants.Break;
            };
            
            links.Each(new TLinkAddress[] { constants.Any, constants.Any, constants.Any }, handler);
            
            if (!EqualityComparer<TLinkAddress>.Default.Equals(existingLink, constants.Null))
            {
                return existingLink;
            }
            
            return links.Create(null, null);
        }
    }
}