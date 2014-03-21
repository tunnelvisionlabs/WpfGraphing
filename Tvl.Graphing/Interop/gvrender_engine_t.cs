namespace Tvl.Graphing.Interop
{
    using System;
    using System.Runtime.InteropServices;

    public unsafe struct gvrender_engine_t
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_job_delegate(JobHandle job);
        public IntPtr begin_job;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_job_delegate(JobHandle job);
        public IntPtr end_job;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_graph_delegate(JobHandle job);
        public IntPtr begin_graph;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_graph_delegate(JobHandle job);
        public IntPtr end_graph;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_layer_delegate(JobHandle job, string layerName, int layerNum, int numLayers);
        public IntPtr begin_layer;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_layer_delegate(JobHandle job);
        public IntPtr end_layer;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_page_delegate(JobHandle job);
        public IntPtr begin_page;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_page_delegate(JobHandle job);
        public IntPtr end_page;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_cluster_delegate(JobHandle job);
        public IntPtr begin_cluster;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_cluster_delegate(JobHandle job);
        public IntPtr end_cluster;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_nodes_delegate(JobHandle job);
        public IntPtr begin_nodes;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_nodes_delegate(JobHandle job);
        public IntPtr end_nodes;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_edges_delegate(JobHandle job);
        public IntPtr begin_edges;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_edges_delegate(JobHandle job);
        public IntPtr end_edges;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_node_delegate(JobHandle job);
        public IntPtr begin_node;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_node_delegate(JobHandle job);
        public IntPtr end_node;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_edge_delegate(JobHandle job);
        public IntPtr begin_edge;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_edge_delegate(JobHandle job);
        public IntPtr end_edge;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_anchor_delegate(JobHandle job, string href, string tooltip, string target, string id);
        public IntPtr begin_anchor;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_anchor_delegate(JobHandle job);
        public IntPtr end_anchor;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void begin_label_delegate(JobHandle job, label_type type);
        public IntPtr begin_label;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void end_label_delegate(JobHandle job);
        public IntPtr end_label;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void textpara_delegate(JobHandle job, pointf p, ref textpara_t text);
        public IntPtr textpara;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void resolve_color_delegate(JobHandle job, ref gvcolor_t color);
        public IntPtr resolve_color;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void ellipse_delegate(JobHandle job, [MarshalAs(UnmanagedType.LPArray, SizeConst = 2)]pointf[] ps, [MarshalAs(UnmanagedType.Bool)]bool filled);
        public IntPtr ellipse;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void polygon_delegate(JobHandle job, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]pointf[] A, int n, [MarshalAs(UnmanagedType.Bool)]bool filled);
        public IntPtr polygon;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void beziercurve_delegate(JobHandle job, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]pointf[] A, int n, [MarshalAs(UnmanagedType.Bool)]bool arrow_at_start, [MarshalAs(UnmanagedType.Bool)]bool arrow_at_end, [MarshalAs(UnmanagedType.Bool)]bool filled);
        public IntPtr beziercurve;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void polyline_delegate(JobHandle job, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]pointf[] A, int n);
        public IntPtr polyline;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void comment_delegate(JobHandle job, string text);
        public IntPtr comment;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void library_shape_delegate(JobHandle job, string name, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]pointf[] A, int n, [MarshalAs(UnmanagedType.Bool)]bool filled);
        public IntPtr library_shape;
    }
}
