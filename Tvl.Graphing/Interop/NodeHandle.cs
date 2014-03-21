namespace Tvl.Graphing.Interop
{
    using System;

    public struct NodeHandle : IEquatable<NodeHandle>
    {
        public static readonly NodeHandle Zero = new NodeHandle();

        private readonly IntPtr _handle;

        public unsafe NodeHandle(Agnode_t* node)
        {
            _handle = (IntPtr)node;
        }

        public static bool operator ==(NodeHandle a, NodeHandle b)
        {
            return a._handle == b._handle;
        }

        public static bool operator !=(NodeHandle a, NodeHandle b)
        {
            return a._handle == b._handle;
        }

        public static unsafe implicit operator NodeHandle(Agnode_t* node)
        {
            return new NodeHandle(node);
        }

        public bool Equals(NodeHandle other)
        {
            return other._handle == _handle;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NodeHandle))
                return false;

            return Equals((NodeHandle)obj);
        }

        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }
    }
}
