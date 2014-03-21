namespace Tvl.Graphing.Interop
{
    public unsafe struct Agdict_t
    {
        public byte* name;
        public Dict_t* dict;
        public Agsym_t** list;
    }
}
