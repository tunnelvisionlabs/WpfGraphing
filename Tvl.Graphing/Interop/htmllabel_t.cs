namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public struct htmllabel_t
    {
        public htmllabel_union u;
        public byte kind;

        public unsafe struct htmllabel_union
        {
            public htmltbl_t* tbl;
            public htmltxt_t* txt;
            public htmlimg_t* img;
        }
    }
}
