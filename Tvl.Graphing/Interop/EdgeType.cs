namespace Tvl.Graphing.Interop
{
    public enum EdgeType
    {
        None = 0,
        Line = 1 << 1,
        Pline = 2 << 1,
        Ortho = 3 << 1,
        Spline = 4 << 1,
        Compound = 5 << 1,
    }
}
