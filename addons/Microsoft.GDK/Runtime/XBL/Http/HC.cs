using System;
using GDK.XGamingRuntime.Interop;

namespace GDK.XGamingRuntime

{
    public delegate void HCTraceCallback(Byte[] areaName, HCTraceLevel level, UInt64 threadId, UInt64 timestamp, Byte[] message);

    public partial class SDK
    {
        public partial class XBL
        {
            public static Int32 HCSettingsSetTraceLevel(
                HCTraceLevel traceLevel
                )
            {
                IsHttpClientApiSupported();
                return XblInterop.HCSettingsSetTraceLevel(traceLevel);
            }

            public static Int32 HCSettingsGetTraceLevel(
                out HCTraceLevel traceLevel
                )
            {
                IsHttpClientApiSupported();
                return XblInterop.HCSettingsGetTraceLevel(out traceLevel);
            }

            public static void HCTraceSetTraceToDebugger(
                bool traceToDebugger
                )
            {
                IsHttpClientApiSupported();
                XblInterop.HCTraceSetTraceToDebugger(traceToDebugger);
            }
        }
    }
}
