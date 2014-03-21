namespace Tvl.Graphing.Interop
{
    using boolean = System.Byte;

    public unsafe struct layout_t
    {
        public double quantum;
        public double scale;
        public double ratio;		/* set only if ratio_kind == R_VALUE */
        public double dpi;
        public pointf margin;
        public pointf page;
        public pointf size;
        public boolean filled;
        public boolean landscape;
        public boolean centered;
        public Ratio ratio_kind;
        public void* xdots;
        public byte* id;
    }
}
