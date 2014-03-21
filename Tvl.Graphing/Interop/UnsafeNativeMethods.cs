namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    using System.Runtime.InteropServices;

    public static class UnsafeNativeMethods
    {
        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agstrcanon([MarshalAs(UnmanagedType.LPStr)]string unk1, [MarshalAs(UnmanagedType.LPStr)]string unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agcanonical([MarshalAs(UnmanagedType.LPStr)]string unk1);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agcanon([MarshalAs(UnmanagedType.LPStr)]string unk1);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int aghtmlstr([MarshalAs(UnmanagedType.LPStr)]string s);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agget(GraphHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agxget(GraphHandle component, int unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agset(GraphHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agsafeset(GraphHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3, [MarshalAs(UnmanagedType.LPStr)]string unk4);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agxset(GraphHandle component, int unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agindex(GraphHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agget(NodeHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agxget(NodeHandle component, int unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agset(NodeHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agsafeset(NodeHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3, [MarshalAs(UnmanagedType.LPStr)]string unk4);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agxset(NodeHandle component, int unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agindex(NodeHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agget(EdgeHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string agxget(EdgeHandle component, int unk2);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agset(EdgeHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agsafeset(EdgeHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3, [MarshalAs(UnmanagedType.LPStr)]string unk4);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agxset(EdgeHandle component, int unk2, [MarshalAs(UnmanagedType.LPStr)]string unk3);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agindex(EdgeHandle component, [MarshalAs(UnmanagedType.LPStr)]string unk2);

#if false
        public static void aginit()
        {
            // aginitlib(sizeof(Agraph_t),sizeof(Agnode_t),sizeof(Agedge_t))
            aginitlib(sizeof(Agraph_t), sizeof(Agnode_t), sizeof(Agedge_t));
        }
#endif

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void aginitlib(int unk1, int unk2, int unk3);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern GraphHandle agopen(string name, GraphType kind);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern GraphHandle agsubg(GraphHandle graph, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern GraphHandle agfindsubg(GraphHandle graph, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void agclose(GraphHandle graph);

        //[DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern Agraph_t *agread(FILE *);

        //[DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern Agraph_t *agread_usergets(FILE *, gets_f);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void agreadline(int unk1);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void agsetfile([MarshalAs(UnmanagedType.LPStr)]string unk1);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern GraphHandle agmemread([MarshalAs(UnmanagedType.LPStr)]string unk1);

        //[DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern void agsetiodisc(
        //    char * (*myfgets) (char *s, int size, FILE *stream),
        //    size_t (*myfwrite) (const void *ptr, size_t size, size_t nmemb, FILE *stream),
        //    int (*myferror) (FILE *stream) );

        //[DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern int agputs(const char *s, FILE *fp);

        //[DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern int agputc(int c, FILE *fp);

        //[DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern int agwrite(Agraph_t *, FILE *);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agerrors();

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agreseterrors();

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern GraphHandle agprotograph();

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern NodeHandle agprotonode(GraphHandle graph);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agprotoedge(GraphHandle graph);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern GraphHandle agusergraph(NodeHandle node);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agnnodes(GraphHandle graph);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agnedges(GraphHandle graph);


        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void aginsert(GraphHandle graph, GraphHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void agdelete(GraphHandle graph, GraphHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agcontains(GraphHandle graph, GraphHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void aginsert(GraphHandle graph, NodeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void agdelete(GraphHandle graph, NodeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agcontains(GraphHandle graph, NodeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void aginsert(GraphHandle graph, EdgeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void agdelete(GraphHandle graph, EdgeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int agcontains(GraphHandle graph, EdgeHandle component);


        #region nodes

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern NodeHandle agnode(GraphHandle graph, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern NodeHandle agfindnode(GraphHandle graph, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern NodeHandle agfstnode(GraphHandle graph);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern NodeHandle agnxtnode(GraphHandle graph, NodeHandle node);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern NodeHandle aglstnode(GraphHandle graph);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern NodeHandle agprvnode(GraphHandle graph, NodeHandle node);

        #endregion

        #region edges

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agedge(GraphHandle graph, NodeHandle tail, NodeHandle head);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agfindedge(GraphHandle graph, NodeHandle tail, NodeHandle head);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agfstedge(GraphHandle graph, NodeHandle node);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agnxtedge(GraphHandle graph, EdgeHandle edge, NodeHandle node);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agfstin(GraphHandle graph, NodeHandle node);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agnxtin(GraphHandle graph, EdgeHandle edge);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agfstout(GraphHandle graph, NodeHandle node);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern EdgeHandle agnxtout(GraphHandle graph, EdgeHandle edge);

        #endregion

        #region attributes

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agattr(GraphHandle component, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agattr(NodeHandle component, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agattr(EdgeHandle component, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agraphattr(GraphHandle graph, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agnodeattr(GraphHandle node, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agedgeattr(GraphHandle edge, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agfindattr(GraphHandle component, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agfstattr(GraphHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agnxtattr(GraphHandle component, SymbolHandle attribute);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle aglstattr(GraphHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agprvattr(GraphHandle component, SymbolHandle attribute);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agfindattr(NodeHandle component, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agfstattr(NodeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agnxtattr(NodeHandle component, SymbolHandle attribute);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle aglstattr(NodeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agprvattr(NodeHandle component, SymbolHandle attribute);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agfindattr(EdgeHandle component, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agfstattr(EdgeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agnxtattr(EdgeHandle component, SymbolHandle attribute);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle aglstattr(EdgeHandle component);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SymbolHandle agprvattr(EdgeHandle component, SymbolHandle attribute);

        //[DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern int      agcopyattr(void *, void *);	

        #endregion

        #region errors

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void agseterr(agerrlevel_t lvl);

        [DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string aglasterr();

        //// This function is not exported from graph.dll
        //[DllImport(ExternDll.Graph, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern agusererrf agseterrf(agusererrf newf);

        #endregion

        #region gvc

        /* FIXME - this needs eliminating or renaming */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void gvToggle(int s);

        /* set up a graphviz context */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SafeContextHandle gvNEWcontext([MarshalAs(UnmanagedType.LPArray)]lt_symlist_t[] builtins, bool demand_loading);

        /*  set up a graphviz context - and init graph - retaining old API */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SafeContextHandle gvContext();

        /*  set up a graphviz context - and init graph - with builtins */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern SafeContextHandle gvContextPlugins([MarshalAs(UnmanagedType.LPArray)]lt_symlist_t[] builtins, [MarshalAs(UnmanagedType.Bool)]bool demand_loading);

        /* get information associated with a graphviz context */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern unsafe char** gvcInfo(SafeContextHandle gvc);

        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string gvcVersion(SafeContextHandle gvc);

        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string gvcBuildDate(SafeContextHandle gvc);

        /* parse command line args - minimally argv[0] sets layout engine */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int gvParseArgs(SafeContextHandle gvc, int argc, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1, ArraySubType = UnmanagedType.LPStr)]string[] argv);

        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern GraphHandle gvNextInputGraph(SafeContextHandle gvc);

        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern GraphHandle gvPluginsGraph(SafeContextHandle gvc);

        /* Compute a layout using a specified engine */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int gvLayout(SafeContextHandle gvc, GraphHandle g, [MarshalAs(UnmanagedType.LPStr)]string engine);

        /* Compute a layout using layout engine from command line args */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int gvLayoutJobs(SafeContextHandle gvc, GraphHandle g);

        /* Render layout into string attributes of the graph */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void attach_attrs(GraphHandle g);

        /* Parse an html string */
#if !WITH_CGRAPH
        //[DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern string agstrdup_html(string s);

        //[DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        //public static extern int aghtmlstr(string s);
#endif

        /* Render layout in a specified format to an open FILE */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int gvRender(SafeContextHandle gvc, GraphHandle g, [MarshalAs(UnmanagedType.LPStr)]string format, IntPtr FILE_out);

        /* Render layout in a specified format to an open FILE */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int gvRenderFilename(SafeContextHandle gvc, GraphHandle g, [MarshalAs(UnmanagedType.LPStr)]string format, [MarshalAs(UnmanagedType.LPStr)]string filename);

        /* Render layout in a specified format to an external context */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern unsafe int gvRenderContext(SafeContextHandle gvc, GraphHandle g, [MarshalAs(UnmanagedType.LPStr)]string format, void* context);

        /* Render layout in a specified format to a malloc'ed string */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern unsafe int gvRenderData(SafeContextHandle gvc, GraphHandle g, [MarshalAs(UnmanagedType.LPStr)]string format, byte** result, uint* length);

        /* Render layout according to -T and -o options found by gvParseArgs */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int gvRenderJobs(SafeContextHandle gvc, GraphHandle g);

        /* Clean up layout data structures - layouts are not nestable (yet) */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int gvFreeLayout(SafeContextHandle gvc, GraphHandle g);

        /* Clean up graphviz context */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void gvFinalize(SafeContextHandle gvc);

        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern int gvFreeContext(IntPtr gvc);

        /* Return list of plugins of type kind.
         * kind would normally be "render" "layout" "textlayout" "device" "loadimage"
         * The size of the list is stored in sz.
         * The caller is responsible for freeing the storage. This involves
         * freeing each item, then the list.
         * Returns NULL on error, or if there are no plugins.
         * In the former case, sz is unchanged; in the latter, sz = 0.
         *
         * At present, the str argument is unused, but may be used to modify
         * the search as in gvplugin_list above.
         */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern unsafe byte** gvPluginList(SafeContextHandle gvc, [MarshalAs(UnmanagedType.LPStr)]string kind, out int sz, [MarshalAs(UnmanagedType.LPStr)]string unused);

        public static string[] gvPluginList(SafeContextHandle gvc, string kind)
        {
            int count;
            unsafe
            {
                byte** data = gvPluginList(gvc, kind, out count, null);
                string[] result = new string[count];
                for (int i = 0; i < count; i++)
                {
                    result[i] = Marshal.PtrToStringAnsi((IntPtr)data[i]);
                    gfree((IntPtr)data[i]);
                }

                gfree((IntPtr)data);
                return result;
            }
        }

        /** Add a library from your user application
         * @param gvc Graphviz context to add library to
         * @param lib library to add
         */
        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern unsafe void gvAddLibrary(SafeContextHandle gvc, gvplugin_library_t* lib);

        [DllImport(ExternDll.Gvc, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern void gfree(IntPtr ptr);

        #endregion
    }
}
