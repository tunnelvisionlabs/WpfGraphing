namespace Tvl.Graphing.Interop
{
    public unsafe struct Agedge_t
    {
        public ComponentKind kind;
        public byte** attr;
        public byte* didset;
        public Agnode_t* head;
        public Agnode_t* tail;
        public int id;
        public Agedgeinfo_t u;

        public override string ToString()
        {
            string tailName = tail != null ? tail->Name : "{null}";
            string headName = head != null ? head->Name : "{null}";
            return string.Format("edge {0}->{1}", tailName, headName);
        }
    }
}
