using System;

namespace Unity.XGamingRuntime
{
    partial class SDK
    {
        private const string k_ResourcesFolderName = "GDKEditionAutoGen";

        private static int? s_CachedEditionNumber = null;

        public static Int32 GetGdkEdition()
        {
            return 250400;
        }
    }
};