namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct gvplugin_active_loadimage_t
    {
        public gvloadimage_engine_t* engine;
        public int id;
        public byte* type;
    }
}
