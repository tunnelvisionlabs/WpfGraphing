namespace Tvl.Graphing.WpfRendering
{
    using Tvl.Graphing.Interop;

    public class WpfDeviceEngine : DeviceEngine
    {
        public WpfDeviceEngine()
            : base("wpf:wpf")
        {
            unsafe
            {
                Features->flags = DeviceFeatures.DoesTrueColor;
                Features->default_margin = new pointf(0, 0);
                Features->default_pagesize = new pointf(612, 792);
                Features->default_dpi = new pointf(72, 72);
            }
        }
    }
}
