namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;

    [DebuggerDisplay("(x={x}, y={y})")]
    public struct pointf
    {
        public double x;
        public double y;

        public pointf(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("(x={0}, y={1})", x, y);
        }
    }
}
