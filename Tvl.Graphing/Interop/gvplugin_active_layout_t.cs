namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    public unsafe struct gvplugin_active_layout_t
    {
        public gvlayout_engine_t* engine;
        public int id;
        public gvlayout_features_t* features;
        public byte* type;

        public string Type
        {
            get
            {
                if (type == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)type);
            }
        }
    }
}
