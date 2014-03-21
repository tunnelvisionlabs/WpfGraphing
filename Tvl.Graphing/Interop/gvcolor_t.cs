namespace Tvl.Graphing.Interop
{
    using System.Runtime.InteropServices;

    public unsafe struct gvcolor_t
    {
        public gvcolor_union u;
        public color_type_t type;

        [StructLayout(LayoutKind.Explicit)]
        public struct gvcolor_union
        {
            [FieldOffset(0)]
            public fixed double RGBA[4];

            [FieldOffset(0)]
            public fixed double HSVA[4];

            [FieldOffset(0)]
            public fixed byte rgba[4];

            [FieldOffset(0)]
            public fixed byte cmyk[4];

            [FieldOffset(0)]
            public fixed int rrggbbaa[4];

            [FieldOffset(0)]
            public byte* @string;

            [FieldOffset(0)]
            public int index;
        }
    }
}
