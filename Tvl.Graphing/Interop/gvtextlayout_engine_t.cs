namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    public unsafe struct gvtextlayout_engine_t
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool textlayout_delegate(textpara_t* para, byte** fontpath);
        public IntPtr textlayout;
    }
}
