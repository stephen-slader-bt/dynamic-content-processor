using LaunchLoader;
using System;
using System.Reflection;

namespace LaunchProcessor.OutputClasses
{
    public sealed class OutputProcessor : DynamicContentProcessor
    {
        public override bool ovr_OutputContent()
        {
            // Do nothing here
            return true;
        }

        public override bool ovr_ProcessType(Type type)
        {
            if (!typeof(OutputType).IsAssignableFrom(type))
                return false;

            if (!type.IsDefined(typeof(RegisterOutputAttribute)))
                return false;

            RegisterOutputAttribute attr = (RegisterOutputAttribute)type.GetCustomAttribute(typeof(RegisterOutputAttribute), false);

            OutputManager.RegisterOutputType(attr.Name, type);

            return true;
        }
    }
}
