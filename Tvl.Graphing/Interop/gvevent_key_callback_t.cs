namespace Tvl.Graphing.Interop
{
    using System.Runtime.InteropServices;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
    public delegate int gvevent_key_callback_t(JobHandle job);
}
