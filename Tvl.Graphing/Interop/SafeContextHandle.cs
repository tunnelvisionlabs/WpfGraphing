namespace Tvl.Graphing.Interop
{
    using System;
    using Microsoft.Win32.SafeHandles;

    public sealed class SafeContextHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        internal unsafe SafeContextHandle(GVC_t* handle, bool ownsHandle)
            : base(ownsHandle)
        {
            SetHandle((IntPtr)handle);
        }

        internal SafeContextHandle(IntPtr handle, bool ownsHandle)
            : base(ownsHandle)
        {
            SetHandle(handle);
        }

        private SafeContextHandle()
            : base(true)
        {
        }

        public string ConfigPath
        {
            get
            {
                unsafe
                {
                    GVC_t* handle = (GVC_t*)DangerousGetHandle();
                    return handle->ConfigPath;
                }
            }
        }

        public string GraphName
        {
            get
            {
                unsafe
                {
                    GVC_t* handle = (GVC_t*)DangerousGetHandle();
                    return handle->GraphName;
                }
            }
        }

        public string LayerDelimiters
        {
            get
            {
                unsafe
                {
                    GVC_t* handle = (GVC_t*)DangerousGetHandle();
                    return handle->LayerDelimiters;
                }
            }
        }

        public string[] InputFileNames
        {
            get
            {
                unsafe
                {
                    GVC_t* handle = (GVC_t*)DangerousGetHandle();
                    return handle->InputFileNames;
                }
            }
        }

        protected override bool ReleaseHandle()
        {
            UnsafeNativeMethods.gvFreeContext(handle);
            return true;
        }
    }
}
