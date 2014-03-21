namespace Tvl.Graphing.Interop
{
    public unsafe struct GVG_t
    {
        /// <summary>
        /// parent gvc
        /// </summary>
        public GVC_t* gvc;

        /// <summary>
        /// next gvg in list
        /// </summary>
        public GVG_t* next;

        /// <summary>
        /// or null if stdin
        /// </summary>
        public byte* input_filename;

        /// <summary>
        /// index of graph within input_file
        /// </summary>
        public int graph_index;

        public Agraph_t* g;
    }
}
