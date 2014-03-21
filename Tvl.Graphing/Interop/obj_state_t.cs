namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    public unsafe struct obj_state_t
    {
        public obj_state_t* parent;

        public obj_type type;
        public void* u;
        //union {
        //    graph_t *g;
        //    graph_t *sg;  
        //    node_t *n;
        //    edge_t *e;
        //} u;

        public emit_state_t emit_state;

        public gvcolor_t pencolor;
        public gvcolor_t fillcolor;
        public pen_type pen;
        public fill_type fill;
        public double penwidth;
        public byte** rawstyle;

        public double z;   /* z depths for 2.5D renderers such as vrml */
        public double tail_z;
        public double head_z;

        /* fully substituted text strings */
        public byte* label;
        public byte* xlabel;
        public byte* taillabel;
        public byte* headlabel;

        public byte* url;              /* if GVRENDER_DOES_MAPS */
        public byte* id;
        public byte* labelurl;
        public byte* tailurl;
        public byte* headurl;

        public byte* tooltip;          /* if GVRENDER_DOES_TOOLTIPS */
        public byte* labeltooltip;
        public byte* tailtooltip;
        public byte* headtooltip;

        public byte* target;           /* if GVRENDER_DOES_TARGETS */
        public byte* labeltarget;
        public byte* tailtarget;
        public byte* headtarget;

        //int explicit_tooltip:1;
        //int explicit_tailtooltip:1;
        //int explicit_headtooltip:1;
        //int explicit_labeltooltip:1;
        //int explicit_tailtarget:1;
        //int explicit_headtarget:1;
        //int explicit_edgetarget:1;
        //int explicit_tailurl:1;
        //int explicit_headurl:1;
        public int explicit_options;


        /* primary mapped region - node shape, edge labels */
        public map_shape_t url_map_shape;
        public int url_map_n;                  /* number of points for url map if GVRENDER_DOES_MAPS */
        public pointf* url_map_p;

        /* additonal mapped regions for edges */
        public int url_bsplinemap_poly_n;      /* number of polygons in url bspline map
					 if GVRENDER_DOES_MAPS && GVRENDER_DOES_MAP_BSPLINES */
        public int* url_bsplinemap_n;          /* array of url_bsplinemap_poly_n ints 
					 of number of points in each polygon */
        public pointf* url_bsplinemap_p;       /* all the polygon points */

        public int tailendurl_map_n;           /* tail end intersection with node */
        public pointf* tailendurl_map_p;

        public int headendurl_map_n;           /* head end intersection with node */
        public pointf* headendurl_map_p;

        public string Label
        {
            get
            {
                if (label == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)label);
            }
        }

        public string XLabel
        {
            get
            {
                if (xlabel == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)xlabel);
            }
        }

        public string TailLabel
        {
            get
            {
                if (taillabel == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)taillabel);
            }
        }

        public string HeadLabel
        {
            get
            {
                if (headlabel == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)headlabel);
            }
        }

        public string Url
        {
            get
            {
                if (url == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)url);
            }
        }

        public string Id
        {
            get
            {
                if (id == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)id);
            }
        }

        public string LabelUrl
        {
            get
            {
                if (labelurl == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)labelurl);
            }
        }

        public string TailUrl
        {
            get
            {
                if (tailurl == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)tailurl);
            }
        }

        public string HeadUrl
        {
            get
            {
                if (headurl == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)headurl);
            }
        }

        public string Tooltip
        {
            get
            {
                if (tooltip == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)tooltip);
            }
        }

        public string LabelTooltip
        {
            get
            {
                if (labeltooltip == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)labeltooltip);
            }
        }

        public string TailTooltip
        {
            get
            {
                if (tailtooltip == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)tailtooltip);
            }
        }

        public string HeadTooltip
        {
            get
            {
                if (headtooltip == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)headtooltip);
            }
        }

        public string Target
        {
            get
            {
                if (target == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)target);
            }
        }

        public string LabelTarget
        {
            get
            {
                if (labeltarget == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)labeltarget);
            }
        }

        public string TailTarget
        {
            get
            {
                if (tailtarget == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)tailtarget);
            }
        }

        public string HeadTarget
        {
            get
            {
                if (headtarget == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)headtarget);
            }
        }
    }
}
