namespace Tvl.Graphing.WpfRendering
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Shapes;
    using Tvl.Graphing.Interop;
    using Point = System.Windows.Point;
    using TextAlignment = System.Windows.TextAlignment;
    using TextBlock = System.Windows.Controls.TextBlock;
    using Thickness = System.Windows.Thickness;
    using Window = System.Windows.Window;

    public class WpfRenderEngine : RenderEngine
    {
        private Canvas _canvas;

        public WpfRenderEngine()
            : base("wpf")
        {
            unsafe
            {
                Features->flags = RenderFeatures.GVRENDER_Y_GOES_DOWN | RenderFeatures.GVRENDER_DOES_TOOLTIPS | RenderFeatures.GVRENDER_DOES_TARGETS;
                Features->default_pad = 0;
                Features->color_type = color_type_t.RGBA_BYTE;
            }
        }

        protected override void BeginJob(JobHandle job)
        {
            _canvas = new Canvas();
        }

        protected override void EndJob(JobHandle job)
        {
            try
            {
                if (_canvas != null)
                {
                    Window window = new Window();
                    window.Content = _canvas;
                    window.Title = job.Context.GraphName;
                    window.SnapsToDevicePixels = true;
                    window.ShowDialog();
                }
            }
            finally
            {
                _canvas = null;
            }
        }

        protected override void BeginGraph(JobHandle job)
        {
        }

        protected override void EndGraph(JobHandle job)
        {
        }

        protected override void BeginLayer(JobHandle job, string layerName, int n, int nLayers)
        {
        }

        protected override void EndLayer(JobHandle job)
        {
        }

        protected override void BeginPage(JobHandle job)
        {
        }

        protected override void EndPage(JobHandle job)
        {
        }

        protected override void BeginCluster(JobHandle job)
        {
        }

        protected override void EndCluster(JobHandle job)
        {
        }

        protected override void BeginNodes(JobHandle job)
        {
        }

        protected override void EndNodes(JobHandle job)
        {
        }

        protected override void BeginEdges(JobHandle job)
        {
        }

        protected override void EndEdges(JobHandle job)
        {
        }

        protected override void BeginNode(JobHandle job)
        {
        }

        protected override void EndNode(JobHandle job)
        {
        }

        protected override void BeginEdge(JobHandle job)
        {
        }

        protected override void EndEdge(JobHandle job)
        {
        }

        protected override void BeginAnchor(JobHandle job, string href, string tooltip, string target, string id)
        {
        }

        protected override void EndAnchor(JobHandle job)
        {
        }

        protected override void BeginLabel(JobHandle job, label_type type)
        {
        }

        protected override void EndLabel(JobHandle job)
        {
        }

        protected override void TextParagraph(JobHandle job, pointf p, ref textpara_t text)
        {
            TextBlock block = new TextBlock();
            block.Inlines.Add(text.Text);
            block.FontFamily = new FontFamily(text.FontName);
            block.FontSize = text.fontsize;
            block.Margin = new Thickness(p.x - text.width / 2, p.y - text.yoffset_centerline - text.height / 2, 0, 0);
            block.Height = text.height;
            block.Width = text.width;
            block.Foreground = GetForegroundBrush(job);
            block.Background = GetBackgroundBrush(job, false);

            switch ((char)text.just)
            {
            case 'l':
                block.TextAlignment = TextAlignment.Left;
                break;

            case 'n':
                block.TextAlignment = TextAlignment.Center;
                break;

            case 'r':
                block.TextAlignment = TextAlignment.Right;
                break;
            }

            _canvas.Children.Add(block);
        }

        protected override void ResolveColor(JobHandle job, ref gvcolor_t color)
        {
            //if (color != null && color->type == color_type_t.RGBA_BYTE)
            //{
            //    _brush = new SolidColorBrush(Color.FromArgb(color->u.rgba[3], color->u.rgba[0], color->u.rgba[1], color->u.rgba[2]));
            //}
            //else
            //{
            //    _brush = Brushes.Black;
            //}
        }

        protected override void Ellipse(JobHandle job, pointf[] ps, bool filled)
        {
            pointf center = ps[0];
            pointf corner = ps[1];

            Ellipse ellipse = new Ellipse();
            ellipse.Width = 2 * (corner.x - center.x);
            ellipse.Height = 2 * (center.y - corner.y);
            ellipse.Margin = new Thickness(2 * center.x - corner.x, corner.y, 0, 0);

            ApplyShapeStyle(ellipse, job, filled);

            _canvas.Children.Add(ellipse);
        }

        protected override void Polygon(JobHandle job, pointf[] A, int n, bool filled)
        {
            Polygon polygon = new Polygon();
            for (int i = 0; i < n; i++)
                polygon.Points.Add(new Point(A[i].x, A[i].y));

            ApplyShapeStyle(polygon, job, filled);

            _canvas.Children.Add(polygon);
        }

        protected override void BezierCurve(JobHandle job, pointf[] A, int n, bool arrow_at_start, bool arrow_at_end, bool filled)
        {
            List<PathFigure> figures = new List<PathFigure>();

            if (n % 3 == 1 && n >= 4)
            {
                PathFigure figure = new PathFigure();
                figure.StartPoint = new Point(A[0].x, A[0].y);

                for (int i = 0; i < n / 3; i++)
                {
                    Point point1 = new Point(A[3 * i + 1].x, A[3 * i + 1].y);
                    Point point2 = new Point(A[3 * i + 2].x, A[3 * i + 2].y);
                    Point point3 = new Point(A[3 * i + 3].x, A[3 * i + 3].y);
                    figure.Segments.Add(new BezierSegment(point1, point2, point3, true));
                }

                figures.Add(figure);
            }
            else
            {
                throw new NotImplementedException();
            }

            Path path;
            path = new Path()
            {
                Data = new PathGeometry(figures)
            };

            ApplyShapeStyle(path, job, filled);

            _canvas.Children.Add(path);

            //PathGeometry geometry = new PathGeometry();

            //PathFigure figure = new PathFigure();
            //figure.Segments.Add(new BezierSegment());

            //geometry.Figures.Add(new PathFigure());

            //path.Data = new PathGeometry();
            //PathGeometry geometry = (PathGeometry)path.Data;
        }

        protected override void Polyline(JobHandle job, pointf[] A, int n)
        {
            Polyline polyline = new Polyline();
            for (int i = 0; i < n; i++)
                polyline.Points.Add(new Point(A[i].x, A[i].y));

            ApplyShapeStyle(polyline, job, false);

            _canvas.Children.Add(polyline);
        }

        protected override void Comment(JobHandle job, string text)
        {
            //string t = Marshal.PtrToStringAnsi((IntPtr)text);
        }

        protected override void LibraryShape(JobHandle job, string name, pointf[] A, int n, bool filled)
        {
        }

        private static Brush GetForegroundBrush(JobHandle job)
        {
            gvcolor_t color = job.State.PenColor;
            if (color.type != color_type_t.RGBA_BYTE)
                throw new NotImplementedException();

            unsafe
            {
                Brush brush = new SolidColorBrush(Color.FromArgb(color.u.rgba[3], color.u.rgba[0], color.u.rgba[1], color.u.rgba[2]));
                return brush;
            }
        }

        private static Brush GetBackgroundBrush(JobHandle job, bool forceSolid)
        {
            fill_type fillType = forceSolid ? fill_type.Solid : job.State.FillType;

            if (fillType == fill_type.None)
                return null;

            if (fillType != fill_type.Solid)
                throw new NotImplementedException();

            gvcolor_t color = job.State.FillColor;
            if (color.type != color_type_t.RGBA_BYTE)
                throw new NotImplementedException();

            unsafe
            {
                Brush brush = new SolidColorBrush(Color.FromArgb(color.u.rgba[3], color.u.rgba[0], color.u.rgba[1], color.u.rgba[2]));
                return brush;
            }
        }

        private static void ApplyShapeStyle(Shape shape, JobHandle job, bool forceFilled)
        {
            shape.Stroke = GetForegroundBrush(job);

            double penWidth = job.State.PenWidth;
            shape.StrokeThickness = job.State.PenWidth;
            switch (job.State.PenType)
            {
            case pen_type.Dashed:
                shape.StrokeDashArray = new DoubleCollection(new double[] { 3 * Math.Max(penWidth, 2), 2 * Math.Max(penWidth, 2) });
                break;

            case pen_type.Dotted:
                shape.StrokeDashArray = new DoubleCollection(new double[] { Math.Max(penWidth, 2), Math.Max(penWidth, 2) });
                break;

            case pen_type.Solid:
            case pen_type.None:
            default:
                break;
            }

            shape.Fill = GetBackgroundBrush(job, forceFilled);
        }
    }
}
