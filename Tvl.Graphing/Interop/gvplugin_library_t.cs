namespace Tvl.Graphing.Interop
{
    public unsafe struct gvplugin_library_t
    {
        /// <summary>
        /// used when this plugin is builtin and has no pathname
        /// </summary>
        public byte* packagename;

        public gvplugin_api_t* apis;
    }
}
