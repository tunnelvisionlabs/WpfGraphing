namespace Tvl.Graphing.Interop
{
    using System;
    using boolean = System.Byte;

    public unsafe struct GVJ_t
    {
        /// <summary>
        /// Parent gvc
        /// </summary>
        public GVC_t* gvc;

        /// <summary>
        /// Linked list of jobs
        /// </summary>
        public GVJ_t* next;

        /// <summary>
        /// Linked list of active jobs (e.g. multiple windows)
        /// </summary>
        public GVJ_t* next_active;

        public GVCOMMON_t* common;

        /// <summary>
        /// objects can be nested (at least clusters can)
        /// so keep object state on a stack
        /// </summary>
        public obj_state_t* obj;
        public byte* input_filename;
        public int graph_index;

        public byte* layout_type;

        public byte* output_filename;
        public IntPtr output_file;
        public byte* output_data;
        public uint output_data_allocated;
        public uint output_data_position;

        public byte* output_langname;
        public int output_lang;

        public gvplugin_active_render_t render;
        public gvplugin_active_device_t device;
        public gvplugin_active_loadimage_t loadimage;
        public gvdevice_callbacks_t* callbacks;
        public pointf device_dpi;
        public boolean device_sets_dpi;

        public void* display;
        public int screen;

        /// <summary>
        /// gd or cairo surface
        /// </summary>
        public void* context;

        /// <summary>
        /// context belongs to caller
        /// </summary>
        public boolean external_context;

        /// <summary>
        /// location of imagedata
        /// </summary>
        public byte* imagedata;

        /// <summary>
        /// emit_graph flags
        /// </summary>
        public int flags;

        /// <summary>
        /// number of layers
        /// </summary>
        public int numLayers;

        /// <summary>
        /// current layer (1-based)
        /// </summary>
        public int layerNum;

        /// <summary>
        /// 2D size of page array
        /// </summary>
        public point pagesArraySize;
        /// <summary>
        /// 2D starting corner in
        /// </summary>
        public point pagesArrayFirst;
        /// <summary>
        /// 2D major increment
        /// </summary>
        public point pagesArrayMajor;
        /// <summary>
        /// 2D minor increment
        /// </summary>
        public point pagesArrayMinor;
        /// <summary>
        /// 2D coord of current page - 0,0 based
        /// </summary>
        public point pagesArrayElem;
        /// <summary>
        /// number of pages
        /// </summary>
        public int numPages;

        /// <summary>
        /// graph bb with padding - graph units
        /// </summary>
        public boxf bb;
        /// <summary>
        /// padding around bb - graph units
        /// </summary>
        public pointf pad;
        /// <summary>
        /// clip region in graph units
        /// </summary>
        public boxf clip;
        /// <summary>
        /// current page in graph units
        /// </summary>
        public boxf pageBox;
        /// <summary>
        /// page size in graph units
        /// </summary>
        public pointf pageSize;
        /// <summary>
        /// viewport focus - graph units
        /// </summary>
        public pointf focus;

        /// <summary>
        /// viewport zoom factor (points per graph unit)
        /// </summary>
        public double zoom;
        /// <summary>
        /// viewport rotation (degrees)  0=portrait, 90=landscape
        /// </summary>
        public int rotation;

        /// <summary>
        /// viewport size - points
        /// </summary>
        public pointf view;

        /// <summary>
        /// viewport area - points
        /// </summary>
        public boxf canvasBox;

        /// <summary>
        /// job-specific margin - points
        /// </summary>
        public pointf margin;

        /// <summary>
        /// device resolution device-units-per-inch
        /// </summary>
        public pointf dpi;

        /// <summary>
        /// device width - device units
        /// </summary>
        public uint width;

        /// <summary>
        /// device height - device units
        /// </summary>
        public uint height;

        /// <summary>
        /// rotated boundingBox - device units
        /// </summary>
        public box pageBoundingBox;

        /// <summary>
        /// cumulative boundingBox over all pages - device units
        /// </summary>
        public box boundingBox;

        /// <summary>
        /// composite device to graph units (zoom and dpi)
        /// </summary>
        public pointf scale;
        /// <summary>
        /// composite translation
        /// </summary>
        public pointf translation;
        /// <summary>
        /// composite device to points: dpi, y_goes_down
        /// </summary>
        public pointf devscale;

        public boolean fit_mode;
        public boolean needs_refresh;
        public boolean click;
        public boolean has_grown;
        public boolean has_been_rendered;

        /// <summary>
        /// active button
        /// </summary>
        public byte button;
        /// <summary>
        /// pointer position in device units
        /// </summary>
        public pointf pointer;
        /// <summary>
        /// old pointer position in device units
        /// </summary>
        public pointf oldpointer;

        /// <summary>
        /// graph object that pointer is in currently
        /// </summary>
        public void* current_obj;

        /// <summary>
        /// graph object that has been selected
        /// (e.g. button 1 clicked on current obj)
        /// </summary>
        public void* selected_obj;
        /// <summary>
        /// tooltip of active object - or NULL
        /// </summary>
        public byte* active_tooltip;
        /// <summary>
        /// href of selected object - or NULL
        /// </summary>
        public byte* selected_href;
        /// <summary>
        /// (e.g. "edge" "node3" "e" "->" "node5" "")
        /// </summary>
        public gv_argvlist_t selected_obj_type_name;
        /// <summary>
        /// attribute triplets: name, value, type
        /// e.g. "color", "red", GVATTR_COLOR,
        /// "style", "filled", GVATTR_BOOL,
        /// </summary>
        public gv_argvlist_t selected_obj_attributes;

        /// <summary>
        /// display-specific data for gvrender plugin
        /// </summary>
        public void* window;

        /// <summary>
        /// keybindings for keyboard events
        /// </summary>
        public gvevent_key_binding_t* keybindings;
        public int numkeys;
        public void* keycodes;
    }
}
