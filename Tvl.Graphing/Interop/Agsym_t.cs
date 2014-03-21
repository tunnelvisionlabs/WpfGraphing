namespace Tvl.Graphing.Interop
{
    using System;
    using System.Runtime.InteropServices;

    public unsafe struct Agsym_t
    {
        public byte* name;
        public byte* value;
        public int index;
        public byte printed;
        public byte @fixed;

        public string Name
        {
            get
            {
                if (name == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)name);
            }
        }

        public string Value
        {
            get
            {
                if (value == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)value);
            }
        }
    }
}
