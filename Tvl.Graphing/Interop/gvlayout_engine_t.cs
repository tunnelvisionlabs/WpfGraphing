namespace Tvl.Graphing.Interop
{
    using System;
    using System.Runtime.InteropServices;

    public struct gvlayout_engine_t
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void layout_delegate(GraphHandle graph);
        public IntPtr layout;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cleanup_delegate(GraphHandle graph);
        public IntPtr cleanup;
    }
}
