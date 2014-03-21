namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;

    [DebuggerDisplay("(x={x}, y={y})")]
    public struct point
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return string.Format("(x={0}, y={1})", x, y);
        }
    }
}
