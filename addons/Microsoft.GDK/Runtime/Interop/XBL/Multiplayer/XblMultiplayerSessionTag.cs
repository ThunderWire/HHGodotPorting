using System;
using System.Runtime.InteropServices;

namespace GDK.XGamingRuntime.Interop
{
    //typedef struct XblMultiplayerSessionTag
    //{
    //    char value[XBL_MULTIPLAYER_SEARCH_HANDLE_MAX_FIELD_LENGTH];
    //}
    //XblMultiplayerSessionTag;
    [StructLayout(LayoutKind.Sequential)]
    internal struct XblMultiplayerSessionTag
    {
        private unsafe fixed Byte value[XblInterop.XBL_MULTIPLAYER_SEARCH_HANDLE_MAX_FIELD_LENGTH];
        internal string GetValue() { unsafe { fixed (Byte* ptr = this.value) { return Converters.BytePointerToString(ptr, XblInterop.XBL_MULTIPLAYER_SEARCH_HANDLE_MAX_FIELD_LENGTH); } } }

        internal XblMultiplayerSessionTag(XGamingRuntime.XblMultiplayerSessionTag publicObject)
        {
            unsafe
            {
                fixed (Byte* ptr = this.value)
                {
                    Converters.StringToNullTerminatedUTF8FixedPointer(publicObject.Value, ptr, XblInterop.XBL_MULTIPLAYER_SEARCH_HANDLE_MAX_FIELD_LENGTH);
                }
            }
        }
    }
}