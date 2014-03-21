namespace Tvl.Graphing.Interop
{
    using System.Diagnostics;

    [DebuggerDisplay("(LL={LL}, UR={UR})")]
    public struct boxf
    {
        public pointf LL;
        public pointf UR;
    }
}
