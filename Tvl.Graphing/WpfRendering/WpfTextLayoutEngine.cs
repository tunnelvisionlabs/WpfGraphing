namespace Tvl.Graphing.WpfRendering
{
    using System.Windows.Controls;
    using System.Windows.Media;
    using Tvl.Graphing.Interop;
    using Size = System.Windows.Size;
    using TextAlignment = System.Windows.TextAlignment;

    public class WpfTextLayoutEngine : TextLayoutEngine
    {
        public WpfTextLayoutEngine()
            : base("wpf:textlayout")
        {
        }

        protected override unsafe bool TextLayout(textpara_t* text, byte** fontpath)
        {
            TextBlock label = new TextBlock();
            label.Inlines.Add(text->Text);
            label.FontFamily = new FontFamily(text->FontName);
            label.FontSize = text->fontsize;

            switch ((char)text->just)
            {
            case 'l':
                label.TextAlignment = TextAlignment.Left;
                break;

            case 'n':
                label.TextAlignment = TextAlignment.Center;
                break;

            case 'r':
                label.TextAlignment = TextAlignment.Right;
                break;
            }

            label.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            Size desiredSize = label.DesiredSize;
            text->width = desiredSize.Width;
            text->height = desiredSize.Height;
            text->yoffset_centerline = 3;

            return true;
        }
    }
}
