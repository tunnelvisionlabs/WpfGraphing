namespace Tvl.Graphing.Interop
{
    using System;

    public struct ComponentKind
    {
        public uint data;

        public int Tag
        {
            get
            {
                return (int)(data & 0x0007);
            }

            set
            {
                if (value < 0 || value > 0x0007)
                    throw new ArgumentOutOfRangeException();

                data = (data & ~0x0007U) | (uint)value;
            }
        }

        public int Kind
        {
            get
            {
                return (int)(data & 0x0070) >> 4;
            }

            set
            {
                if (value < 0 || value > 0x0007)
                    throw new ArgumentOutOfRangeException();

                data = (data & ~0x0070U) | ((uint)value << 4);
            }
        }

        public int Handle
        {
            get
            {
                return (int)((data & ~0x0077U) >> 8);
            }

            set
            {
                if (value < 0 || value > (uint.MaxValue >> 8))
                    throw new ArgumentOutOfRangeException();

                data = (data & ~0x0070U) | ((uint)value << 8);
            }
        }
    }
}
