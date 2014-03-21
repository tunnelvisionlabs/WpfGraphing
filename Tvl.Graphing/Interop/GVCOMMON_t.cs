namespace Tvl.Graphing.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using boolean = System.Byte;

    public unsafe struct GVCOMMON_t
    {
        public byte** info;
        public byte* cmdname;
        public int verbose;
        public boolean config;
        public boolean auto_outfile_names;

        //void (*errorfn) (const char *fmt, ...);
        //public delegate void errorfn_delegate();
        public IntPtr errorfn;

        public byte** show_boxes; /* emit code for correct box coordinates */
        public byte** lib;

        /* rendering state */
        public int viewNum;     /* current view - 1 based count of views,
			    all pages in all layers */
        public lt_symlist_t* builtins;
        public int demand_loading;

        public string CommandName
        {
            get
            {
                if (cmdname == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)cmdname);
            }
        }
    }
}
