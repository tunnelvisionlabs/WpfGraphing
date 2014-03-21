namespace Tvl.Graphing.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.Win32.SafeHandles;

    public sealed class SafeMarshalHGlobalHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeMarshalHGlobalHandle(bool ownsHandle)
            : base(ownsHandle)
        {
        }

        public SafeMarshalHGlobalHandle(IntPtr handle, bool ownsHandle)
            : base(ownsHandle)
        {
            SetHandle(handle);
        }

        protected override bool ReleaseHandle()
        {
            Marshal.FreeHGlobal(handle);
            return true;
        }
    }
}
