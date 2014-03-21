namespace Tvl.Graphing.Interop
{
    using System;

    public struct EdgeHandle : IEquatable<EdgeHandle>
    {
        public static readonly EdgeHandle Zero = new EdgeHandle();

        private readonly IntPtr _handle;

        public unsafe EdgeHandle(Agedge_t* edge)
        {
            _handle = (IntPtr)edge;
        }

        public static bool operator ==(EdgeHandle a, EdgeHandle b)
        {
            return a._handle == b._handle;
        }

        public static bool operator !=(EdgeHandle a, EdgeHandle b)
        {
            return a._handle == b._handle;
        }

        public static unsafe implicit operator EdgeHandle(Agedge_t* edge)
        {
            return new EdgeHandle(edge);
        }

        public bool Equals(EdgeHandle other)
        {
            return other._handle == _handle;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is EdgeHandle))
                return false;

            return Equals((EdgeHandle)obj);
        }

        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }
    }
}
