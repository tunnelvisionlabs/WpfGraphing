namespace Tvl.Graphing.Interop
{
    using System;

    public struct ObjectStateHandle
    {
        private IntPtr _handle;

        internal unsafe ObjectStateHandle(obj_state_t* handle)
        {
            _handle = (IntPtr)handle;
        }

        public gvcolor_t FillColor
        {
            get
            {
                unsafe
                {
                    obj_state_t* state = (obj_state_t*)_handle;
                    return state->fillcolor;
                }
            }
        }

        public gvcolor_t PenColor
        {
            get
            {
                unsafe
                {
                    obj_state_t* state = (obj_state_t*)_handle;
                    return state->pencolor;
                }
            }
        }

        public double PenWidth
        {
            get
            {
                unsafe
                {
                    obj_state_t* state = (obj_state_t*)_handle;
                    return state->penwidth;
                }
            }
        }

        public pen_type PenType
        {
            get
            {
                unsafe
                {
                    obj_state_t* state = (obj_state_t*)_handle;
                    return state->pen;
                }
            }
        }

        public fill_type FillType
        {
            get
            {
                unsafe
                {
                    obj_state_t* state = (obj_state_t*)_handle;
                    return state->fill;
                }
            }
        }
    }
}
