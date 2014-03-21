namespace Tvl.Graphing.Interop
{
    using System;

    [Flags]
    public enum RenderFeatures
    {
        None = 0,

        /// <summary>
        /// device origin top left, y goes down, otherwise device origin lower left, y goes up
        /// </summary>
        GVRENDER_Y_GOES_DOWN = (1 << 12),

        /// <summary>
        /// device uses scale, translate, rotate to do its own coordinate transformations, otherwise coordinates are pre-transformed
        /// </summary>
        GVRENDER_DOES_TRANSFORM = (1 << 13),

        /// <summary>
        /// renderer has its own idea of arrow shapes
        /// </summary>
        [Obsolete]
        GVRENDER_DOES_ARROWS = (1 << 14),

        /// <summary>
        /// basically, maps don't need labels
        /// </summary>
        GVRENDER_DOES_LABELS = (1 << 15),

        /// <summary>
        /// renderer encodes mapping information for mouse events -Tcmapx -Tsvg
        /// </summary>
        GVRENDER_DOES_MAPS = (1 << 16),

        /// <summary>
        /// supports a 2 coord rectangle optimization
        /// </summary>
        GVRENDER_DOES_MAP_RECTANGLE = (1 << 17),

        /// <summary>
        /// supports a 1 coord + radius circle optimization
        /// </summary>
        GVRENDER_DOES_MAP_CIRCLE = (1 << 18),

        /// <summary>
        /// supports polygons (basically, -Tsvg uses anchors, so doesn't need to support any map shapes)
        /// </summary>
        GVRENDER_DOES_MAP_POLYGON = (1 << 19),

        /// <summary>
        /// supports a 2 coord ellipse optimization
        /// </summary>
        GVRENDER_DOES_MAP_ELLIPSE = (1 << 20),

        /// <summary>
        /// supports mapping of splines
        /// </summary>
        GVRENDER_DOES_MAP_BSPLINE = (1 << 21),

        /// <summary>
        /// can represent tooltip info -Tcmapx, -Tsvg
        /// </summary>
        GVRENDER_DOES_TOOLTIPS = (1 << 22),

        /// <summary>
        /// can represent target info (open link in a new tab or window)
        /// </summary>
        GVRENDER_DOES_TARGETS = (1 << 23),

        /// <summary>
        /// render support 2.5D representation -Tvrml
        /// </summary>
        GVRENDER_DOES_Z = (1 << 24),

        /// <summary>
        /// don't paint white background, assumes white paper -Tps
        /// </summary>
        GVRENDER_NO_WHITE_BG = (1 << 25),
    }
}
