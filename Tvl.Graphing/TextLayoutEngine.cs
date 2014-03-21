namespace Tvl.Graphing
{
    using System;
    using System.Runtime.InteropServices;
    using Tvl.Graphing.Interop;

    public abstract class TextLayoutEngine : PluginEngine
    {
        private readonly SafeMarshalHGlobalHandle _textLayoutEngine;
        private readonly SafeMarshalHGlobalHandle _installedPluginData;
        private readonly SafeMarshalHGlobalHandle _engineType;

        private readonly gvtextlayout_engine_t.textlayout_delegate _textlayout;

        public TextLayoutEngine(string type)
        {
            unsafe
            {
                this._textlayout = TextLayout;

                gvtextlayout_engine_t* textLayoutEngine = (gvtextlayout_engine_t*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(gvtextlayout_engine_t)));
                _textLayoutEngine = new SafeMarshalHGlobalHandle((IntPtr)textLayoutEngine, true);

                *textLayoutEngine = new gvtextlayout_engine_t();
                textLayoutEngine->textlayout = Marshal.GetFunctionPointerForDelegate(_textlayout);

                gvplugin_installed_t* installedPluginData = (gvplugin_installed_t*)Marshal.AllocHGlobal(2 * Marshal.SizeOf(typeof(gvplugin_installed_t)));
                _installedPluginData = new SafeMarshalHGlobalHandle((IntPtr)installedPluginData, true);
                _engineType = new SafeMarshalHGlobalHandle(Marshal.StringToHGlobalAnsi(type), true);

                installedPluginData->id = 0;
                installedPluginData->type = (byte*)_engineType.DangerousGetHandle();
                installedPluginData->quality = 0;
                installedPluginData->engine = textLayoutEngine;
                installedPluginData->features = null;
                installedPluginData[1] = new gvplugin_installed_t();
            }
        }

        public override sealed api_t Api
        {
            get
            {
                return api_t.TextLayout;
            }
        }

        public override unsafe gvplugin_installed_t* InstalledPluginData
        {
            get
            {
                return (gvplugin_installed_t*)_installedPluginData.DangerousGetHandle();
            }
        }

        protected virtual unsafe bool TextLayout(textpara_t* text, byte** fontpath)
        {
            return false;
        }
    }
}
