namespace Tvl.Graphing.Interop
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Dtlink_t
    {
        [FieldOffset(0)]
        public Dtlink_t* right;

        [FieldOffset(4)]
        public uint hash;

        [FieldOffset(4)]
        public Dtlink_t* left;
    }
}
