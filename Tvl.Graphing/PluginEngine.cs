namespace Tvl.Graphing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Tvl.Graphing.Interop;

    public abstract class PluginEngine
    {
        public abstract api_t Api
        {
            get;
        }

        public abstract unsafe gvplugin_installed_t* InstalledPluginData
        {
            get;
        }
    }
}
