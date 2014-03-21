namespace Tvl.Graphing.WpfRendering
{
    using System.Linq;
    using Tvl.Graphing.Interop;

    public class WpfLibrary : PluginLibrary
    {
        public WpfLibrary()
            : base("WPF", new WpfRenderEngine(), new WpfDeviceEngine(), new WpfTextLayoutEngine())
        {
        }

        public override void Register(SafeContextHandle context)
        {
            base.Register(context);
            unsafe
            {
                GVC_t* gvc = (GVC_t*)context.DangerousGetHandle();
                PluginEngine textLayoutEngine = Engines.Single(i => i.Api == api_t.TextLayout);
                gvc->textlayout.engine = (gvtextlayout_engine_t*)textLayoutEngine.InstalledPluginData->engine;
            }
        }
    }
}
