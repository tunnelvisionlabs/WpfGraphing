namespace Tvl.Graphing.Interop
{
    using System;
    using System.Runtime.InteropServices;

    public unsafe struct gvloadimage_engine_t
    {
        public delegate void loadimage_delegate(JobHandle job, usershape_t* us, boxf b, [MarshalAs(UnmanagedType.U1)]bool filled);
        public IntPtr loadimage;
    }
}
