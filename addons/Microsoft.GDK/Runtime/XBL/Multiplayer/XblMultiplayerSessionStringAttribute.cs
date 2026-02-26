using System;
using GDK.XGamingRuntime.Interop;


namespace GDK.XGamingRuntime
{

    public class XblMultiplayerSessionStringAttribute
    {
        public XblMultiplayerSessionStringAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }

        internal XblMultiplayerSessionStringAttribute(Interop.XblMultiplayerSessionStringAttribute interopStruct)
        {
            this.Name = interopStruct.GetName();
            this.Value = interopStruct.GetValue();
        }

        public string Name { get; }
        public string Value { get; }
    }
}
