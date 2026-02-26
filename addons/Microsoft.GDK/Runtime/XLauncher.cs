// Copyright (c) Microsoft Corporation. All rights reserved.

using System;
using GDK.XGamingRuntime.Interop;

namespace GDK.XGamingRuntime
{
    partial class SDK
    {
        public static Int32 XLaunchUri(XUserHandle requestingUser, string uri)
        {
            IntPtr userHandle = (requestingUser != null) ? requestingUser.Handle : IntPtr.Zero;

            return NativeMethods.XLaunchUri(userHandle, uri);
        }
    }
}
