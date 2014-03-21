namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct PostscriptAlias
    {
        public byte* name;
        public byte* family;
        public byte* weight;
        public byte* stretch;
        public byte* style;
        public int xfig_code;
        public byte* svg_font_family;
        public byte* svg_font_weight;
        public byte* svg_font_style;
    }
}
