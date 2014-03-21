namespace Tvl.Graphing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Tvl.Graphing.Interop;
    using System.Windows.Media;
    using System.Runtime.InteropServices;

    public abstract class RenderEngine : PluginEngine
    {
        private readonly SafeMarshalHGlobalHandle _renderEngine;
        private readonly SafeMarshalHGlobalHandle _renderFeatures;
        private readonly SafeMarshalHGlobalHandle _installedPluginData;
        private readonly SafeMarshalHGlobalHandle _engineType;

        private readonly gvrender_engine_t.begin_job_delegate _begin_job;
        private readonly gvrender_engine_t.end_job_delegate _end_job;
        private readonly gvrender_engine_t.begin_graph_delegate _begin_graph;
        private readonly gvrender_engine_t.end_graph_delegate _end_graph;
        private readonly gvrender_engine_t.begin_layer_delegate _begin_layer;
        private readonly gvrender_engine_t.end_layer_delegate _end_layer;
        private readonly gvrender_engine_t.begin_page_delegate _begin_page;
        private readonly gvrender_engine_t.end_page_delegate _end_page;
        private readonly gvrender_engine_t.begin_cluster_delegate _begin_cluster;
        private readonly gvrender_engine_t.end_cluster_delegate _end_cluster;
        private readonly gvrender_engine_t.begin_nodes_delegate _begin_nodes;
        private readonly gvrender_engine_t.end_nodes_delegate _end_nodes;
        private readonly gvrender_engine_t.begin_edges_delegate _begin_edges;
        private readonly gvrender_engine_t.end_edges_delegate _end_edges;
        private readonly gvrender_engine_t.begin_node_delegate _begin_node;
        private readonly gvrender_engine_t.end_node_delegate _end_node;
        private readonly gvrender_engine_t.begin_edge_delegate _begin_edge;
        private readonly gvrender_engine_t.end_edge_delegate _end_edge;
        private readonly gvrender_engine_t.begin_anchor_delegate _begin_anchor;
        private readonly gvrender_engine_t.end_anchor_delegate _end_anchor;
        private readonly gvrender_engine_t.begin_label_delegate _begin_label;
        private readonly gvrender_engine_t.end_label_delegate _end_label;
        private readonly gvrender_engine_t.textpara_delegate _textpara;
        private readonly gvrender_engine_t.resolve_color_delegate _resolve_color;
        private readonly gvrender_engine_t.ellipse_delegate _ellipse;
        private readonly gvrender_engine_t.polygon_delegate _polygon;
        private readonly gvrender_engine_t.beziercurve_delegate _beziercurve;
        private readonly gvrender_engine_t.polyline_delegate _polyline;
        private readonly gvrender_engine_t.comment_delegate _comment;
        private readonly gvrender_engine_t.library_shape_delegate _library_shape;

        public RenderEngine(string type)
        {
            this._begin_job = BeginJob;
            this._end_job = EndJob;
            this._begin_graph = BeginGraph;
            this._end_graph = EndGraph;
            this._begin_layer = BeginLayer;
            this._end_layer = EndLayer;
            this._begin_page = BeginPage;
            this._end_page = EndPage;
            this._begin_cluster = BeginCluster;
            this._end_cluster = EndCluster;
            this._begin_nodes = BeginNodes;
            this._end_nodes = EndNodes;
            this._begin_edges = BeginEdges;
            this._end_edges = EndEdges;
            this._begin_node = BeginNode;
            this._end_node = EndNode;
            this._begin_edge = BeginEdge;
            this._end_edge = EndEdge;
            this._begin_anchor = BeginAnchor;
            this._end_anchor = EndAnchor;
            this._begin_label = BeginLabel;
            this._end_label = EndLabel;
            this._textpara = TextParagraph;
            this._resolve_color = ResolveColor;
            this._ellipse = Ellipse;
            this._polygon = Polygon;
            this._beziercurve = BezierCurve;
            this._polyline = Polyline;
            this._comment = Comment;
            this._library_shape = LibraryShape;

            unsafe
            {
                gvrender_engine_t* renderEngine = (gvrender_engine_t*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(gvrender_engine_t)));
                _renderEngine = new SafeMarshalHGlobalHandle((IntPtr)renderEngine, true);

                *renderEngine = new gvrender_engine_t();
                renderEngine->begin_job = Marshal.GetFunctionPointerForDelegate(_begin_job);
                renderEngine->end_job = Marshal.GetFunctionPointerForDelegate(_end_job);
                renderEngine->begin_graph = Marshal.GetFunctionPointerForDelegate(_begin_graph);
                renderEngine->end_graph = Marshal.GetFunctionPointerForDelegate(_end_graph);
                renderEngine->begin_layer = Marshal.GetFunctionPointerForDelegate(_begin_layer);
                renderEngine->end_layer = Marshal.GetFunctionPointerForDelegate(_end_layer);
                renderEngine->begin_page = Marshal.GetFunctionPointerForDelegate(_begin_page);
                renderEngine->end_page = Marshal.GetFunctionPointerForDelegate(_end_page);
                renderEngine->begin_cluster = Marshal.GetFunctionPointerForDelegate(_begin_cluster);
                renderEngine->end_cluster = Marshal.GetFunctionPointerForDelegate(_end_cluster);
                renderEngine->begin_nodes = Marshal.GetFunctionPointerForDelegate(_begin_nodes);
                renderEngine->end_nodes = Marshal.GetFunctionPointerForDelegate(_end_nodes);
                renderEngine->begin_edges = Marshal.GetFunctionPointerForDelegate(_begin_edges);
                renderEngine->end_edges = Marshal.GetFunctionPointerForDelegate(_end_edges);
                renderEngine->begin_node = Marshal.GetFunctionPointerForDelegate(_begin_node);
                renderEngine->end_node = Marshal.GetFunctionPointerForDelegate(_end_node);
                renderEngine->begin_edge = Marshal.GetFunctionPointerForDelegate(_begin_edge);
                renderEngine->end_edge = Marshal.GetFunctionPointerForDelegate(_end_edge);
                renderEngine->begin_anchor = Marshal.GetFunctionPointerForDelegate(_begin_anchor);
                renderEngine->end_anchor = Marshal.GetFunctionPointerForDelegate(_end_anchor);
                renderEngine->begin_label = Marshal.GetFunctionPointerForDelegate(_begin_label);
                renderEngine->end_label = Marshal.GetFunctionPointerForDelegate(_end_label);
                renderEngine->textpara = Marshal.GetFunctionPointerForDelegate(_textpara);
                renderEngine->resolve_color = Marshal.GetFunctionPointerForDelegate(_resolve_color);
                renderEngine->ellipse = Marshal.GetFunctionPointerForDelegate(_ellipse);
                renderEngine->polygon = Marshal.GetFunctionPointerForDelegate(_polygon);
                renderEngine->beziercurve = Marshal.GetFunctionPointerForDelegate(_beziercurve);
                renderEngine->polyline = Marshal.GetFunctionPointerForDelegate(_polyline);
                renderEngine->comment = Marshal.GetFunctionPointerForDelegate(_comment);
                renderEngine->library_shape = Marshal.GetFunctionPointerForDelegate(_library_shape);

                gvrender_features_t* renderFeatures = (gvrender_features_t*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(gvrender_features_t)));
                _renderFeatures = new SafeMarshalHGlobalHandle((IntPtr)renderFeatures, true);
                *renderFeatures = new gvrender_features_t();

                gvplugin_installed_t* installedPluginData = (gvplugin_installed_t*)Marshal.AllocHGlobal(2 * Marshal.SizeOf(typeof(gvplugin_installed_t)));
                _installedPluginData = new SafeMarshalHGlobalHandle((IntPtr)installedPluginData, true);
                _engineType = new SafeMarshalHGlobalHandle(Marshal.StringToHGlobalAnsi(type), true);

                installedPluginData->id = 0;
                installedPluginData->type = (byte*)_engineType.DangerousGetHandle();
                installedPluginData->quality = 0;
                installedPluginData->engine = renderEngine;
                installedPluginData->features = renderFeatures;
                installedPluginData[1] = new gvplugin_installed_t();
            }
        }

        public override sealed api_t Api
        {
            get
            {
                return api_t.Render;
            }
        }

        public override unsafe gvplugin_installed_t* InstalledPluginData
        {
            get
            {
                return (gvplugin_installed_t*)_installedPluginData.DangerousGetHandle();
            }
        }

        internal unsafe gvrender_features_t* Features
        {
            get
            {
                return (gvrender_features_t*)_renderFeatures.DangerousGetHandle();
            }
        }

        protected virtual void BeginJob(JobHandle job)
        {
        }

        protected virtual void EndJob(JobHandle job)
        {
        }

        protected virtual void BeginGraph(JobHandle job)
        {
        }

        protected virtual void EndGraph(JobHandle job)
        {
        }

        protected virtual void BeginLayer(JobHandle job, string layerName, int n, int nLayers)
        {
        }

        protected virtual void EndLayer(JobHandle job)
        {
        }

        protected virtual void BeginPage(JobHandle job)
        {
        }

        protected virtual void EndPage(JobHandle job)
        {
        }

        protected virtual void BeginCluster(JobHandle job)
        {
        }

        protected virtual void EndCluster(JobHandle job)
        {
        }

        protected virtual void BeginNodes(JobHandle job)
        {
        }

        protected virtual void EndNodes(JobHandle job)
        {
        }

        protected virtual void BeginEdges(JobHandle job)
        {
        }

        protected virtual void EndEdges(JobHandle job)
        {
        }

        protected virtual void BeginNode(JobHandle job)
        {
        }

        protected virtual void EndNode(JobHandle job)
        {
        }

        protected virtual void BeginEdge(JobHandle job)
        {
        }

        protected virtual void EndEdge(JobHandle job)
        {
        }

        protected virtual void BeginAnchor(JobHandle job, string href, string tooltip, string target, string id)
        {
        }

        protected virtual void EndAnchor(JobHandle job)
        {
        }

        protected virtual void BeginLabel(JobHandle job, label_type type)
        {
        }

        protected virtual void EndLabel(JobHandle job)
        {
        }

        protected virtual void TextParagraph(JobHandle job, pointf p, ref textpara_t text)
        {
        }

        protected virtual void ResolveColor(JobHandle job, ref gvcolor_t color)
        {
        }

        protected virtual void Ellipse(JobHandle job, pointf[] ps, bool filled)
        {
        }

        protected virtual void Polygon(JobHandle job, pointf[] A, int n, bool filled)
        {
        }

        protected virtual void BezierCurve(JobHandle job, pointf[] A, int n, bool arrow_at_start, bool arrow_at_end, bool filled)
        {
        }

        protected virtual void Polyline(JobHandle job, pointf[] A, int n)
        {
        }

        protected virtual void Comment(JobHandle job, string text)
        {
        }

        protected virtual void LibraryShape(JobHandle job, string name, pointf[] A, int n, bool filled)
        {
        }
    }
}
