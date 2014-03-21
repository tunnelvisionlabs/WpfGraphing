namespace Tvl.Sample.Graphing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Tvl.Graphing.Interop;
    using Tvl.Graphing.WpfRendering;
    using Tvl.Graphing;

    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            // initialize
            using (SafeContextHandle gvc = UnsafeNativeMethods.gvContext())
            {
                //UnsafeNativeMethods.aginit();
                //UnsafeNativeMethods.agnodeattr(null, "label", "\\N");
                //GVC_t* gvc = UnsafeNativeMethods.gvNEWcontext(null, true);
                //UnsafeNativeMethods.gvconfig(gvc, false);

                //DotLibrary library = new DotLibrary(gvc);
                //library.Register();
                WpfLibrary library = new WpfLibrary();
                library.Register(gvc);

                int result;

                string[] layoutPlugins = UnsafeNativeMethods.gvPluginList(gvc, "layout");
                string[] renderPlugins = UnsafeNativeMethods.gvPluginList(gvc, "render");

                // create graph
                GraphHandle graph = createGraph2();
                //GraphHandle graph = createRailroadGraph();

                result = UnsafeNativeMethods.gvLayout(gvc, graph, "dot");
                if (result != 0)
                {
                    string message = UnsafeNativeMethods.aglasterr();
                    throw new Exception(message);
                }

                //result = UnsafeNativeMethods.gvLayout(gvc, graph, "nop");
                //if (result != 0)
                //{
                //    string message = UnsafeNativeMethods.aglasterr();
                //    throw new Exception(message);
                //}

                drawGraph(gvc, graph);
                UnsafeNativeMethods.gvFreeLayout(gvc, graph);
                UnsafeNativeMethods.agclose(graph);
            }
        }

        private static GraphHandle createGraph()
        {
            GraphHandle graph = UnsafeNativeMethods.agopen("G", GraphType.Directed | GraphType.Strict);
            NodeHandle nodeA = UnsafeNativeMethods.agnode(graph, "A");
            NodeHandle nodeB = UnsafeNativeMethods.agnode(graph, "B");
            EdgeHandle edge = UnsafeNativeMethods.agedge(graph, nodeA, nodeB);
            //int result = UnsafeNativeMethods.agsafeset(edge, "dir", "forward", null);
            return graph;
        }

        private static GraphHandle createGraph2()
        {
            GraphHandle graph = UnsafeNativeMethods.agopen("G", GraphType.Directed | GraphType.Strict);
            UnsafeNativeMethods.agsafeset(graph, "label", "One Cool Graph", null);

            NodeHandle COMMENT = UnsafeNativeMethods.agnode(graph, "COMMENT");
            UnsafeNativeMethods.agsafeset(COMMENT, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(COMMENT, "style", "filled", null);
            UnsafeNativeMethods.agsafeset(COMMENT, "color", "lightblue", null);

            NodeHandle DOC_COMMENT = UnsafeNativeMethods.agnode(graph, "DOC_COMMENT");
            UnsafeNativeMethods.agsafeset(DOC_COMMENT, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(DOC_COMMENT, "style", "filled", null);
            UnsafeNativeMethods.agsafeset(DOC_COMMENT, "color", "lightblue", null);

            NodeHandle error = UnsafeNativeMethods.agnode(graph, "error");
            UnsafeNativeMethods.agsafeset(error, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(error, "style", "filled", null);
            UnsafeNativeMethods.agsafeset(error, "color", "red", null);

            NodeHandle PopDN1 = UnsafeNativeMethods.agnode(graph, "PopDN1");
            UnsafeNativeMethods.agsafeset(PopDN1, "style", "filled", null);

            NodeHandle PopN1 = UnsafeNativeMethods.agnode(graph, "PopN1");
            UnsafeNativeMethods.agsafeset(PopN1, "style", "filled", null);

            NodeHandle PushDN1 = UnsafeNativeMethods.agnode(graph, "PushDN1");
            UnsafeNativeMethods.agsafeset(PushDN1, "style", "filled", null);

            NodeHandle PushN1 = UnsafeNativeMethods.agnode(graph, "PushN1");
            UnsafeNativeMethods.agsafeset(PushN1, "style", "filled", null);

            NodeHandle dns1 = UnsafeNativeMethods.agnode(graph, "dns1");
            NodeHandle dns2 = UnsafeNativeMethods.agnode(graph, "dns2");
            NodeHandle dns3 = UnsafeNativeMethods.agnode(graph, "dns3");
            NodeHandle ds1 = UnsafeNativeMethods.agnode(graph, "ds1");
            NodeHandle ds2 = UnsafeNativeMethods.agnode(graph, "ds2");
            NodeHandle ds3 = UnsafeNativeMethods.agnode(graph, "ds3");
            NodeHandle ds4 = UnsafeNativeMethods.agnode(graph, "ds4");
            NodeHandle ns1 = UnsafeNativeMethods.agnode(graph, "ns1");
            NodeHandle ns2 = UnsafeNativeMethods.agnode(graph, "ns2");
            NodeHandle ns3 = UnsafeNativeMethods.agnode(graph, "ns3");
            NodeHandle s1 = UnsafeNativeMethods.agnode(graph, "s1");
            NodeHandle s2 = UnsafeNativeMethods.agnode(graph, "s2");
            NodeHandle s3 = UnsafeNativeMethods.agnode(graph, "s3");
            NodeHandle s4 = UnsafeNativeMethods.agnode(graph, "s4");
            NodeHandle s5 = UnsafeNativeMethods.agnode(graph, "s5");
            NodeHandle s6 = UnsafeNativeMethods.agnode(graph, "s6");
            NodeHandle s7 = UnsafeNativeMethods.agnode(graph, "s7");
            NodeHandle s8 = UnsafeNativeMethods.agnode(graph, "s8");
            NodeHandle start = UnsafeNativeMethods.agnode(graph, "start");

            EdgeHandle edge = null;

            edge = UnsafeNativeMethods.agedge(graph, PopDN1, dns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "!Empty", null);
            UnsafeNativeMethods.agsafeset(edge, "style", "dotted", null);

            edge = UnsafeNativeMethods.agedge(graph, PopDN1, ds1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "Empty", null);
            UnsafeNativeMethods.agsafeset(edge, "style", "dashed", null);

            edge = UnsafeNativeMethods.agedge(graph, PopN1, ns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "!Empty", null);

            edge = UnsafeNativeMethods.agedge(graph, PopN1, s6);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "Empty", null);

            edge = UnsafeNativeMethods.agedge(graph, PushDN1, dns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);

            edge = UnsafeNativeMethods.agedge(graph, PushN1, ns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);

            edge = UnsafeNativeMethods.agedge(graph, dns1, dns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, dns1, dns2);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'*'", null);

            edge = UnsafeNativeMethods.agedge(graph, dns1, dns3);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, dns2, dns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, dns3, dns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, ds1, ds2);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'*'", null);

            edge = UnsafeNativeMethods.agedge(graph, ds1, ds3);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, ds2, ds1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, ds2, ds4);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, ns1, ns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, ns1, ns2);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'*'", null);

            edge = UnsafeNativeMethods.agedge(graph, ns1, ns3);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, ns2, ns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, ns3, ns1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, s1, s2);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'*'", null);

            edge = UnsafeNativeMethods.agedge(graph, s2, s3);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'*'", null);

            edge = UnsafeNativeMethods.agedge(graph, s2, s6);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, s2, s8);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, s3, ds1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, s3, s4);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, s6, s7);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'*'", null);

            edge = UnsafeNativeMethods.agedge(graph, s6, s8);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, s7, s5);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, s7, s6);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, start, error);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "~", null);

            edge = UnsafeNativeMethods.agedge(graph, start, s1);
            UnsafeNativeMethods.agsafeset(edge, "color", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "darkgreen", null);
            UnsafeNativeMethods.agsafeset(edge, "label", "'/'", null);

            edge = UnsafeNativeMethods.agedge(graph, dns2, PopDN1);
            UnsafeNativeMethods.agsafeset(edge, "color", "blue", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "blue", null);

            edge = UnsafeNativeMethods.agedge(graph, dns3, PushDN1);
            UnsafeNativeMethods.agsafeset(edge, "color", "blue", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "blue", null);

            edge = UnsafeNativeMethods.agedge(graph, ds3, PushDN1);
            UnsafeNativeMethods.agsafeset(edge, "color", "blue", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "blue", null);

            edge = UnsafeNativeMethods.agedge(graph, ns2, PopN1);
            UnsafeNativeMethods.agsafeset(edge, "color", "blue", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "blue", null);

            edge = UnsafeNativeMethods.agedge(graph, ns3, PushN1);
            UnsafeNativeMethods.agsafeset(edge, "color", "blue", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "blue", null);

            edge = UnsafeNativeMethods.agedge(graph, s8, PushN1);
            UnsafeNativeMethods.agsafeset(edge, "color", "blue", null);
            UnsafeNativeMethods.agsafeset(edge, "fontcolor", "blue", null);

            edge = UnsafeNativeMethods.agedge(graph, ds4, DOC_COMMENT);
            edge = UnsafeNativeMethods.agedge(graph, s4, COMMENT);
            edge = UnsafeNativeMethods.agedge(graph, s5, COMMENT);

            return graph;
        }

        private static GraphHandle createRailroadGraph()
        {
            GraphHandle graph = UnsafeNativeMethods.agopen("G", GraphType.Directed | GraphType.Strict);

            GraphHandle row1 = UnsafeNativeMethods.agsubg(graph, "row1");
            GraphHandle row2 = UnsafeNativeMethods.agsubg(graph, "row2");

            UnsafeNativeMethods.agsafeset(graph, "rankdir", "LR", null);
            //UnsafeNativeMethods.agsafeset(row1, "rank", "same", null);
            //UnsafeNativeMethods.agsafeset(row2, "rank", "same", null);

            NodeHandle GENERATED = UnsafeNativeMethods.agnode(row1, "GENERATED");
            NodeHandle ALWAYS = UnsafeNativeMethods.agnode(row1, "ALWAYS");
            NodeHandle AS = UnsafeNativeMethods.agnode(row1, "AS");
            NodeHandle BY = UnsafeNativeMethods.agnode(row2, "BY");
            NodeHandle DEFAULT_KW = UnsafeNativeMethods.agnode(row2, "DEFAULT_KW");
            NodeHandle IDENTITY = UnsafeNativeMethods.agnode(row1, "IDENTITY");
            NodeHandle LPAREN = UnsafeNativeMethods.agnode(row1, "LPAREN");
            NodeHandle CommonSequenceOption = UnsafeNativeMethods.agnode(row1, "CommonSequenceOption");
            NodeHandle RPAREN1 = UnsafeNativeMethods.agnode(row1, "RPAREN1");
            NodeHandle RPAREN2 = UnsafeNativeMethods.agnode(row1, "RPAREN2");

            UnsafeNativeMethods.agsafeset(GENERATED, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(ALWAYS, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(AS, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(BY, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(DEFAULT_KW, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(IDENTITY, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(LPAREN, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(CommonSequenceOption, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(RPAREN1, "shape", "record", null);
            UnsafeNativeMethods.agsafeset(RPAREN2, "shape", "record", null);

            UnsafeNativeMethods.agsafeset(RPAREN1, "label", "RPAREN", null);
            UnsafeNativeMethods.agsafeset(RPAREN2, "label", "RPAREN", null);

            UnsafeNativeMethods.agsafeset(GENERATED, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(ALWAYS, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(AS, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(BY, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(DEFAULT_KW, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(IDENTITY, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(LPAREN, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(CommonSequenceOption, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(RPAREN1, "ordering", "out", null);
            UnsafeNativeMethods.agsafeset(RPAREN2, "ordering", "out", null);

            EdgeHandle edge = null;

            edge = UnsafeNativeMethods.agedge(graph, GENERATED, BY);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, BY, DEFAULT_KW);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, DEFAULT_KW, AS);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, GENERATED, ALWAYS);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, ALWAYS, AS);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, AS, IDENTITY);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, IDENTITY, LPAREN);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, IDENTITY, RPAREN2);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, LPAREN, CommonSequenceOption);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, CommonSequenceOption, CommonSequenceOption);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, CommonSequenceOption, RPAREN1);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            edge = UnsafeNativeMethods.agedge(graph, RPAREN1, RPAREN2);
            UnsafeNativeMethods.agsafeset(edge, "tailport", "e", null);
            UnsafeNativeMethods.agsafeset(edge, "headport", "w", null);

            //int result = UnsafeNativeMethods.agsafeset(edge, "dir", "forward", null);
            return graph;
        }

        private static void drawGraph(SafeContextHandle context, GraphHandle g)
        {
            int result = UnsafeNativeMethods.gvRenderFilename(context, g, "wpf", "test.dot");
            if (result != 0)
            {
                string message = UnsafeNativeMethods.aglasterr();
                throw new Exception(message);
            }
        }

        private static int HandleErrorMessage(string message)
        {
            throw new Exception(message);
        }
    }
}
