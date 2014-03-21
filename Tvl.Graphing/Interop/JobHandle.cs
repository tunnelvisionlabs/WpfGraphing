namespace Tvl.Graphing.Interop
{
    using System;

    public struct JobHandle
    {
        private readonly IntPtr _handle;

        internal JobHandle(IntPtr handle)
        {
            _handle = handle;
        }

        public SafeContextHandle Context
        {
            get
            {
                unsafe
                {
                    GVJ_t* job = (GVJ_t*)_handle.ToPointer();
                    return new SafeContextHandle(job->gvc, false);
                }
            }
        }

        public ObjectStateHandle State
        {
            get
            {
                unsafe
                {
                    GVJ_t* job = (GVJ_t*)_handle.ToPointer();
                    return new ObjectStateHandle(job->obj);
                }
            }
        }
    }
}
