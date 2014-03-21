namespace Tvl.Graphing.Interop
{
    using System;

    [Flags]
    public enum LayoutFeatures
    {
        None,
        UsesRankDir = 1 << 0,
    }
}
