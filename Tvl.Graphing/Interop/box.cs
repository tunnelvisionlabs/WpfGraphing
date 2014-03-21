namespace Tvl.Graphing.Interop
{
    using System.Diagnostics;

    [DebuggerDisplay("(LL={LL}, UR={UR})")]
    public struct box
    {
        public point LL;
        public point UR;
    }
}
