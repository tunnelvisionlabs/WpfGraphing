namespace Tvl.Graphing.Interop
{
    using System;

    [Flags]
    public enum GraphType
    {
        None = 0,
        Undirected = 0x0000,
        Directed = 0x0001,
        Strict = 0x0002,
        Meta = 0x0004
    }
}
