namespace Tvl.Graphing.Interop
{
    public unsafe struct gvplugin_available_t
    {
        /// <summary>
        /// next plugin in linked list, or NULL
        /// </summary>
        public gvplugin_available_t* next;

        /// <summary>
        /// type string, e.g. "png" or "ps"
        /// </summary>
        public byte* typestr;

        /// <summary>
        /// Programmer assigned quality ranking within type (+ve or -ve int).
        /// First implementation of type should be given "0" quality
        /// </summary>
        public int quality;

        /// <summary>
        /// details of library containing plugin
        /// </summary>
        public gvplugin_package_t* package;

        /// <summary>
        /// pointer to jumptable for plugin, or NULL if not yet loaded
        /// </summary>
        public gvplugin_installed_t* typeptr;
    }
}
