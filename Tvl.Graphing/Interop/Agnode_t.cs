namespace Tvl.Graphing.Interop
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    [DebuggerDisplay("node {Name}")]
    public unsafe struct Agnode_t
    {
        public ComponentKind kind;
        public byte** attr;
        public byte* didset;
        public byte* name;
        public int id;
        public Agraph_t* graph;
        public Agnodeinfo_t u;

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
