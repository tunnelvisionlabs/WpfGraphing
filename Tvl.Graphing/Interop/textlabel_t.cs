namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using boolean = System.Byte;
    using System.Runtime.InteropServices;

    public unsafe struct textlabel_t
    {
        public byte* text;
        public byte* fontname;
        public byte* fontcolor;
        public int charset;
        public double fontsize;
        public pointf dimen; /* the diagonal size of the label (estimated by layout) */
        public pointf space; /* the diagonal size of the space for the label */
        /*   the rendered label is aligned in this box */
        /*   space does not include pad or margin */
        public pointf pos;   /* the center of the space for the label */
        public textlabel_union u;
        public char valign;  /* 't' 'c' 'b' */
        public boolean set;  /* true if position is set */
        public boolean html; /* true if html label */

        [StructLayout(LayoutKind.Explicit)]
        public struct textlabel_union
        {
            [FieldOffset(0)]
            public text txt;

            [FieldOffset(0)]
            public htmllabel_t* html;

            public struct text
            {
                public textpara_t* para;
                public short nparas;
            }
        }
    }
}
