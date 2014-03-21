namespace Tvl.Graphing.Interop
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    [DebuggerDisplay("graph {Name}")]
    public unsafe struct Agraph_t
    {
        public ComponentKind kind;
        public byte** attr;
        public byte* didset;
        public byte* name;
        public Agdata_t* univ;
        public Dict_t* nodes;
        public Dict_t* inedges;
        public Dict_t* outedges;
        public Agraph_t* root;
        public Agnode_t* meta_node;
        public Agproto_t* proto;
        public Agraphinfo_t u;

        public string Name
        {
            get
            {
                if (name == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)name);
            }
        }
    }
}
