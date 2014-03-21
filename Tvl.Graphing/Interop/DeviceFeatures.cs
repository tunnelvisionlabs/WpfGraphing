namespace Tvl.Graphing.Interop
{
    using System;

    [Flags]
    public enum DeviceFeatures
    {
        None,

        /// <summary>
        /// Provides pagination support -Tps
        /// </summary>
        DoesPages = (1 << 5),

        /// <summary>
        /// Provides support for layers -Tps
        /// </summary>
        DoesLayers = (1 << 6),

        /// <summary>
        /// Supports mouse events -Tgtk, -Txlib
        /// </summary>
        Events = (1 << 7),

        /// <summary>
        /// Supports alpha channel -Tpng, -Tgtk, -Txlib
        /// </summary>
        DoesTrueColor = (1 << 8),

        /// <summary>
        /// Suppresses \r\n substitution for linends
        /// </summary>
        BinaryFormat = (1 << 9),

        /// <summary>
        /// Controls libz compression
        /// </summary>
        CompressedFormat = (1 << 10),

        /// <summary>
        /// Used when gvdevice is not used because device uses its own writer, -Tming, devil outputs   (FIXME seems to overlap OUTPUT_NOT_REQUIRED)
        /// </summary>
        NoWriter = (1 << 11),
    }
}
