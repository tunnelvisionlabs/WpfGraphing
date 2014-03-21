namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct nlist_t
    {
        public Agnode_t** list;
        public int size;
    }
}
