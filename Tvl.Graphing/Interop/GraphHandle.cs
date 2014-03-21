namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;

    public struct GraphHandle : IEquatable<GraphHandle>
    {
        public static readonly GraphHandle Zero = new GraphHandle();

        private readonly IntPtr _handle;

        public unsafe GraphHandle(Agraph_t* graph)
        {
            _handle = (IntPtr)graph;
        }

        public IEnumerable<NodeHandle> Nodes
        {
            get
            {
                int count = UnsafeNativeMethods.agnnodes(this);
                NodeHandle node = NodeHandle.Zero;
                for (int i = 0; i < count; i++)
                {
                    if (node == NodeHandle.Zero)
                        node = UnsafeNativeMethods.agfstnode(this);
                    else
                        node = UnsafeNativeMethods.agnxtnode(this, node);

                    yield return node;
                }
            }
        }

        public static bool operator ==(GraphHandle a, GraphHandle b)
        {
            return a._handle == b._handle;
        }

        public static bool operator !=(GraphHandle a, GraphHandle b)
        {
            return a._handle == b._handle;
        }

        public static unsafe implicit operator GraphHandle(Agraph_t* graph)
        {
            return new GraphHandle(graph);
        }

        public bool Equals(GraphHandle other)
        {
            return other._handle == _handle;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is GraphHandle))
                return false;

            return Equals((GraphHandle)obj);
        }

        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }
    }
}
