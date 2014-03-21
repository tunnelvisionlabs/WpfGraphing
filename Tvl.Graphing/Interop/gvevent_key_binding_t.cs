namespace Tvl.Graphing.Interop
{
    using System;

    public unsafe struct gvevent_key_binding_t
    {
        public byte* keystring;

        //gvevent_key_callback_t callback;
        public IntPtr callback;
    }
}
