namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct gvrender_features_t
    {
        public RenderFeatures flags;
        public double default_pad;	/* graph units */
        public byte** knowncolors;
        public int sz_knowncolors;
        public color_type_t color_type;
    }
}
