namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct gvplugin_active_device_t
    {
        public gvdevice_engine_t* engine;
        public int id;
        public gvdevice_features_t* features;
        public byte* type;
    }
}
