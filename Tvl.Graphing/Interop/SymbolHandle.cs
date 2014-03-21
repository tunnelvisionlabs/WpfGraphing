namespace Tvl.Graphing.Interop
{
    using System;

    public struct SymbolHandle : IEquatable<SymbolHandle>
    {
        public static readonly SymbolHandle Zero = new SymbolHandle();

        private readonly IntPtr _handle;

        public unsafe SymbolHandle(Agsym_t* symbol)
        {
            _handle = (IntPtr)symbol;
        }

        public static bool operator ==(SymbolHandle a, SymbolHandle b)
        {
            return a._handle == b._handle;
        }

        public static bool operator !=(SymbolHandle a, SymbolHandle b)
        {
            return a._handle == b._handle;
        }

        public static unsafe implicit operator SymbolHandle(Agsym_t* symbol)
        {
            return new SymbolHandle(symbol);
        }

        public bool Equals(SymbolHandle other)
        {
            return other._handle == _handle;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is SymbolHandle))
                return false;

            return Equals((SymbolHandle)obj);
        }

        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }
    }
}
