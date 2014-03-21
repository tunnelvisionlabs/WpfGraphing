namespace Tvl.Graphing.Interop
{
    public struct gvdevice_features_t
    {
        public DeviceFeatures flags;
        public pointf default_margin;  /* left/right, top/bottom - points */
        public pointf default_pagesize;/* default page width, height - points */
        public pointf default_dpi;
    }
}
