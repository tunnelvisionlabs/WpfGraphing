namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct gvplugin_api_t
    {
        public api_t api;
        public gvplugin_installed_t* types;
    }
}
