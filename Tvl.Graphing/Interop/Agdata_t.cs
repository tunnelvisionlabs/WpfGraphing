namespace Tvl.Graphing.Interop
{
    public unsafe struct Agdata_t
    {
        public Dict_t* node_dict;
        public Agdict_t* nodeattr;
        public Agdict_t* edgeattr;
        public Agdict_t* globattr;
        public int max_node_id;
        public int max_edge_id;
    }
}
