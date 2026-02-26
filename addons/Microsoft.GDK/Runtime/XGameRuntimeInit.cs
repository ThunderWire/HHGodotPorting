// Copyright (c) Microsoft Corporation. All rights reserved.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using GDK.XGamingRuntime.Interop;
using Microsoft.CSharp;

namespace GDK.XGamingRuntime
{
    //enum class XGameRuntimeGameConfigSource : uint32_t
    //{
    //    Default,
    //    Inline,
    //    File
    //};
    public enum XGameRuntimeGameConfigSource : UInt32
    {
        Default = 0,
        Inline = 1,
        File = 2
    }

    //struct XGameRuntimeOptions
    //{
    //    XGameRuntimeGameConfigSource gameConfigSource;
    //    const char* gameConfig;
    //};
    [StructLayout(LayoutKind.Sequential)]
    public struct XGameRuntimeOptions
    {
        public XGameRuntimeGameConfigSource gameConfigSource;
        [MarshalAs(UnmanagedType.LPStr)]
        public string gameConfig;
    }

    partial class SDK
    {
        public static Int32 XGameRuntimeInitialize()
        {
            return NativeMethods.XGameRuntimeInitialize();
        }

        private static Int32 XGameRuntimeInitializeWithOptions(XGameRuntimeOptions options)
        {
            return NativeMethods.XGameRuntimeInitializeWithOptions(options);
        }

        public static void XGameRuntimeUninitialize()
        {
            NativeMethods.XGameRuntimeUninitialize();
        }

        private static bool XVersionLessThan(XVersion version1, XVersion version2)
        {
            if (version1.Value == version2.Value)
            {
                return false;
            }

            if (version1.Major < version2.Major)
            {
                return false;
            }
            else if (version1.Minor < version2.Minor)
            {
                return false;
            }
            else if (version1.Build < version2.Build)
            {
                return false;
            }
            else if (version1.Revision < version2.Revision)
            {
                return false;
            }

            return true;
        }
    }
}