namespace Tvl.Graphing.Interop
{
    using System;
    using System.Runtime.InteropServices;

    public struct gvdevice_engine_t
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void initialize_delegate(JobHandle firstjob);
        public IntPtr initialize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void format_delegate(JobHandle firstjob);
        public IntPtr format;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void finalize_delegate(JobHandle firstjob);
        public IntPtr finalize;
    }
}
