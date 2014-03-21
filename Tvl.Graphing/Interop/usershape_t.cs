namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct usershape_t
    {
        public Dtlink_t link;
        public byte* name;
        public int macro_id;
        public bool must_inline;
        public bool nocache;
        public IntPtr* f;
        public imagetype_t type;
        public byte* stringtype;
        public int x;
        public int y;
        public int w;
        public int h;
        public int dpi;
        public void* data;                   /* data loaded by a renderer */
        public uint datasize;              /* size of data (if mmap'ed) */

        /* renderer's function for freeing data */
        public delegate void datafree_delegate(usershape_t* us);
        //public datafree_delegate datafree;
        public IntPtr datafree;
    }
}
