namespace Tvl.Graphing.Interop
{
    public unsafe struct gvplugin_installed_t
    {
        /// <summary>
        /// an id that is only unique within a package
        /// of plugins of the same api.
        /// A renderer-type such as "png" in the cairo package
        /// has an id that is different from the "ps" type
        /// in the same package
        /// </summary>
        public int id;

        /// <summary>
        /// a string name, such as "png" or "ps" that
        /// distinguishes different types withing the same
        /// (renderer in this case)
        /// </summary>
        public byte* type;

        /// <summary>
        /// an arbitrary integer used for ordering plugins of
        /// the same type from different packages
        /// </summary>
        public int quality;

        /// <summary>
        /// pointer to the jump table for the plugin
        /// </summary>
        public void* engine;

        /// <summary>
        /// pointer to the feature description
        /// void* because type varies by api
        /// </summary>
        public void* features;
    }
}
