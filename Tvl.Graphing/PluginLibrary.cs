namespace Tvl.Graphing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Tvl.Graphing.Interop;
    using System.Runtime.InteropServices;
    using System.Collections.ObjectModel;

    public class PluginLibrary
    {
        private readonly ReadOnlyCollection<PluginEngine> _engines;

        private SafeMarshalHGlobalHandle _library;
        private SafeMarshalHGlobalHandle _apis;
        private SafeMarshalHGlobalHandle _packageName;

        public PluginLibrary(string name, params PluginEngine[] engines)
        {
            if (engines == null)
                throw new ArgumentNullException("engines");

            _engines = new ReadOnlyCollection<PluginEngine>((PluginEngine[])engines.Clone());

            unsafe
            {
                gvplugin_library_t* library = (gvplugin_library_t*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(gvplugin_library_t)));
                _library = new SafeMarshalHGlobalHandle((IntPtr)library, true);

                library->apis = (gvplugin_api_t*)Marshal.AllocHGlobal((engines.Length + 1) * Marshal.SizeOf(typeof(gvplugin_api_t)));
                _apis = new SafeMarshalHGlobalHandle((IntPtr)library->apis, true);
                library->apis[engines.Length] = new gvplugin_api_t();

                library->packagename = (byte*)Marshal.StringToHGlobalAnsi(name);
                _packageName = new SafeMarshalHGlobalHandle((IntPtr)library->packagename, true);

                for (int i = 0; i < engines.Length; i++)
                {
                    library->apis[i].api = engines[i].Api;
                    library->apis[i].types = engines[i].InstalledPluginData;
                }
            }
        }

        public ReadOnlyCollection<PluginEngine> Engines
        {
            get
            {
                return _engines;
            }
        }

        public virtual void Register(SafeContextHandle context)
        {
            unsafe
            {
                UnsafeNativeMethods.gvAddLibrary(context, (gvplugin_library_t*)_library.DangerousGetHandle());
            }
        }
    }
}
