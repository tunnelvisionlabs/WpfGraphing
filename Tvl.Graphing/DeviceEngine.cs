namespace Tvl.Graphing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Tvl.Graphing.Interop;
    using System.Runtime.InteropServices;

    public abstract class DeviceEngine : PluginEngine
    {
        private readonly SafeMarshalHGlobalHandle _deviceEngine;
        private readonly SafeMarshalHGlobalHandle _deviceFeatures;
        private readonly SafeMarshalHGlobalHandle _installedPluginData;
        private readonly SafeMarshalHGlobalHandle _engineType;

        private readonly gvdevice_engine_t.initialize_delegate _initialize;
        private readonly gvdevice_engine_t.format_delegate _format;
        private readonly gvdevice_engine_t.finalize_delegate _finalize;

        public DeviceEngine(string type)
        {
            this._initialize = Initialize;
            this._format = Format;
            this._finalize = Finalize;

            unsafe
            {
                gvdevice_engine_t* deviceEngine = (gvdevice_engine_t*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(gvdevice_engine_t)));
                _deviceEngine = new SafeMarshalHGlobalHandle((IntPtr)deviceEngine, true);

                *deviceEngine = new gvdevice_engine_t();
                deviceEngine->initialize = Marshal.GetFunctionPointerForDelegate(_initialize);
                deviceEngine->format = Marshal.GetFunctionPointerForDelegate(_format);
                deviceEngine->finalize = Marshal.GetFunctionPointerForDelegate(_finalize);

                gvdevice_features_t* deviceFeatures = (gvdevice_features_t*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(gvdevice_features_t)));
                _deviceFeatures = new SafeMarshalHGlobalHandle((IntPtr)deviceFeatures, true);

                *deviceFeatures = new gvdevice_features_t();
                deviceFeatures->flags = DeviceFeatures.None;
                deviceFeatures->default_margin = new pointf(36, 36);
                deviceFeatures->default_pagesize = new pointf(612, 792);
                deviceFeatures->default_dpi = new pointf(72, 72);

                gvplugin_installed_t* installedPluginData = (gvplugin_installed_t*)Marshal.AllocHGlobal(2 * Marshal.SizeOf(typeof(gvplugin_installed_t)));
                _installedPluginData = new SafeMarshalHGlobalHandle((IntPtr)installedPluginData, true);
                _engineType = new SafeMarshalHGlobalHandle(Marshal.StringToHGlobalAnsi(type), true);

                installedPluginData->id = 0;
                installedPluginData->type = (byte*)_engineType.DangerousGetHandle();
                installedPluginData->quality = 0;
                installedPluginData->engine = deviceEngine;
                installedPluginData->features = deviceFeatures;
                installedPluginData[1] = new gvplugin_installed_t();
            }
        }

        public override sealed api_t Api
        {
            get
            {
                return api_t.Device;
            }
        }

        public override unsafe gvplugin_installed_t* InstalledPluginData
        {
            get
            {
                return (gvplugin_installed_t*)_installedPluginData.DangerousGetHandle();
            }
        }

        internal unsafe gvdevice_features_t* Features
        {
            get
            {
                return (gvdevice_features_t*)_deviceFeatures.DangerousGetHandle();
            }
        }

        protected virtual void Initialize(JobHandle job)
        {
        }

        protected virtual void Format(JobHandle job)
        {
        }

        protected virtual void Finalize(JobHandle job)
        {
        }
    }
}
