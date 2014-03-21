namespace Tvl.Graphing.Interop
{
    using System;
    using System.Runtime.InteropServices;

    public unsafe struct gvdevice_callbacks_t
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void refresh_delegate(JobHandle job);
        public IntPtr refresh;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void button_press_delegate(JobHandle job, int button, pointf pointer);
        public IntPtr button_press;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void button_release_delegate(JobHandle job, int button, pointf pointer);
        public IntPtr button_release;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void motion_delegate(JobHandle job, pointf pointer);
        public IntPtr motion;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void modify_delegate(JobHandle job, string name, string value);
        public IntPtr modify;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void delete_delegate(JobHandle job);
        public IntPtr delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void read_delegate(JobHandle job, string filename, string layout);
        public IntPtr read;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void layout_delegate(JobHandle job, string layout);
        public IntPtr layout;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = false)]
        public delegate void render_delegate(JobHandle job, string format, string filename);
        public IntPtr render;
    }
}
