namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct htmlfont_t
    {
        public byte* name;
        public byte* color;
        public int flags;  /* HTML_UL, HTML_IF, HTML_BF */
        public int cnt;   /* reference count */
        public double size;
    }
}
