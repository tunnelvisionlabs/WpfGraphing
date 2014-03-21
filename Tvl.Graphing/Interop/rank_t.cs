namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using boolean = System.Byte;

    public unsafe struct rank_t
    {
        public int n;			/* number of nodes in this rank  */
        public Agnode_t** v;		/* ordered list of nodes in rank    */
        public int an;			/* globally allocated number of nodes   */
        public Agnode_t** av;		/* allocated list of nodes in rank  */
        public int ht1, ht2;		/* height below/above centerline    */
        public int pht1, pht2;		/* as above, but only primitive nodes   */
        public boolean candidate;	/* for transpose () */
        public boolean valid;
        public int cache_nc;		/* caches number of crossings */
        public adjmatrix_t* flat;
    }
}
