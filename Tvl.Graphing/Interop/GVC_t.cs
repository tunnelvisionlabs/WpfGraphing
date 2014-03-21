namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using boolean = System.Byte;

    // this type only exists as opaque pointers
    public unsafe struct GVC_t
    {
        public const int APIS = 5;

        public GVCOMMON_t common;

        public byte* config_path;
        public boolean config_found;

        /* gvParseArgs */
        public byte** input_filenames; /* null terminated array of input filenames */

        /* gvNextInputGraph() */
        public GVG_t* gvgs;	/* linked list of graphs */
        public GVG_t* gvg;	/* current graph */

        /* plugins */
        //#define ELEM(x) +1
        /* APIS expands to "+1 +1 ... +1" to give the number of APIs */
        // gvplugin_available_t* on 32-bit!
        public fixed int apis[APIS]; /* array of linked-list of plugins per api */
        public fixed int api[APIS];  /* array of current plugins per api */
        //#undef ELEM
        public gvplugin_package_t* packages;   /* list of available packages */

        /* keybindings for keyboard events */
        public gvevent_key_binding_t* keybindings;
        public int numkeys;
        public void* keycodes;

        /* externally provided write() displine */
        //size_t (*write_fn) (GVJ_t *job, const byte *s, size_t len);
        public IntPtr write_fn;

        /* FIXME - everything below should probably move to GVG_t */

        /* gvrender_config() */
        public GVJ_t* jobs;	/* linked list of jobs */
        public GVJ_t* job;	/* current job */

        public Agraph_t* g;      /* current graph */

        /* gvrender_begin_job() */
        public gvplugin_active_textlayout_t textlayout;
        public gvplugin_active_layout_t layout;

        public byte* graphname;	/* name from graph */
        public GVJ_t* active_jobs;   /* linked list of active jobs */

        /* pagination */
        public byte* pagedir;		/* pagination order */
        public pointf margin;		/* margins in graph units */
        public pointf pad;		/* pad in graph units */
        public pointf pageSize;	/* pageSize in graph units, not including margins */
        public point pb;		/* page size - including margins (inches) */
        public boxf bb;		/* graph bb in graph units, not including margins */
        public int rotation;		/* rotation - 0 = portrait, 90 = landscape */
        public boolean graph_sets_pad;
        public boolean graph_sets_margin;
        public boolean graph_sets_pageSize;
        public boolean graph_sets_rotation;

        /* layers */
        public byte* layerDelims;	/* delimiters in layer names */
        public byte* layers;		/* null delimited list of layer names */
        public byte** layerIDs;	/* array of layer names */
        public int numLayers;		/* number of layers */

        /* default font */
        public byte* defaultfontname;
        public double defaultfontsize;

        /* default line style */
        public byte** defaultlinestyle;

        /* render defaults set from graph */
        public gvcolor_t bgcolor;	/* background color */

        /* whether to mangle font names (at least in SVG), usually false */
        public int fontrenaming;

        public string ConfigPath
        {
            get
            {
                if (config_path == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)config_path);
            }
        }

        public string GraphName
        {
            get
            {
                if (graphname == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)graphname);
            }
        }

        public string LayerDelimiters
        {
            get
            {
                if (layerDelims == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)layerDelims);
            }
        }

        public string[] InputFileNames
        {
            get
            {
                List<string> names = new List<string>();
                for (byte** ptr = input_filenames; ptr != null && *ptr != null; ptr++)
                {
                    names.Add(Marshal.PtrToStringAnsi((IntPtr)ptr));
                }

                return names.ToArray();
            }
        }
    }
}
