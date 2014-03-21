namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    public unsafe struct textpara_t
    {
        public byte* str;      /* stored in utf-8 */
        public PostscriptAlias* postscript_alias;
        public void* layout;

        //void (*free_layout) (void *layout);   /* FIXME - this is ugly */
        public delegate void free_layout_delegate(void* layout);
        public IntPtr free_layout;

        public htmlfont_t* font;
        public byte* fontname; /* FIXME - use htmlfont_t */
        public double fontsize; /* FIXME - use htmlfont_t */
        public double size;
        public double yoffset_layout;
        public double yoffset_centerline;
        public double width;
        public double height; /* FIXME */
        /// <summary>
        /// 'l', 'n', or 'r'
        /// </summary>
        public byte just;

        public string Text
        {
            get
            {
                if (str == null)
                    return null;

                int i;
                for (i = 0; str[i] != 0; i++)
                {
                    continue;
                }

                byte[] data = new byte[i];
                Marshal.Copy((IntPtr)str, data, 0, i);
                return Encoding.UTF8.GetString(data);
            }
        }

        public string FontName
        {
            get
            {
                if (fontname == null)
                    return null;

                return Marshal.PtrToStringAnsi((IntPtr)fontname);
            }
        }
    }
}
