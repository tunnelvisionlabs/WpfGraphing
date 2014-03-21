namespace Tvl.Graphing.Interop
{
    using System;
    using boolean = System.Byte;

    public unsafe struct Agraphinfo_t
    {
#if WITH_CGRAPH
        Agrec_t hdr;
#endif
        /* to generate code */
        public layout_t* drawing;
        public textlabel_t* label;	/* if the cluster has a title */
        public boxf bb;			/* bounding box */
        public fixed double border[2 * 4];	/* sizes of margins for graph labels */
        public byte gui_state; /* Graph state for GUI ops */
        public byte has_labels;
        public boolean has_images;
        public byte charset; /* input character set */
        public int rankdir;
        public int ht1;
        public int ht2;	/* below and above extremal ranks */
        public ushort flags;
        public void* alg;
        public GVC_t* gvc;	/* context for "globals" over multiple graphs */

        //void (*cleanup) (graph_t * g);   /* function to deallocate layout-specific data */
        public delegate void cleanup_delegate(Agraph_t* g);
        public IntPtr cleanup;

#if !DOT_ONLY
        /* to place nodes */
        public Agnode_t** neato_nlist;
        public int move;
        public double** dist;
        public double** spring;
        public double** sum_t;
        public double*** t;
        public ushort ndim;
        public ushort odim;
#endif
#if !NEATO_ONLY
        /* to have subgraphs */
        public int n_cluster;
        public Agraph_t** clust;	/* clusters are in clust[1..n_cluster] !!! */
        public Agnode_t* nlist;
        public rank_t* rank;
#if WITH_CGRAPH
        graph_t *parent;        /* containing cluster (not parent subgraph) */
        int level;		/* cluster nesting level (not node level!) */
        node_t	*minrep, *maxrep;	/* set leaders for min and max rank */
#endif

        /* fast graph node list */
        public nlist_t comp;
        /* connected components */
        public Agnode_t* minset;
        public Agnode_t* maxset;	/* set leaders */
        public long n_nodes;
        /* includes virtual */
        public short minrank;
        public short maxrank;

        /* various flags */
        public boolean has_flat_edges;
#if WITH_CGRAPH
        boolean has_sourcerank;
        boolean has_sinkrank;
#endif
        public byte showboxes;
        public boolean cluster_was_collapsed;
        public fontname_kind fontnames;		/* to override mangling in SVG */

        public int nodesep;
        public int ranksep;
        public Agnode_t* ln;
        public Agnode_t* rn;	/* left, right nodes of bounding box */

        /* for clusters */
        public Agnode_t* leader;
        public Agnode_t** rankleader;
        public boolean expanded;
        public byte installed;
        public byte set_type;
        public byte label_pos;
        public boolean exact_ranksep;
#endif
    }
}
