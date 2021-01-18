using LaunchLoader;
using System;
using System.Reflection;

namespace ShapeProcessor
{
    public sealed class ShapeProcessor : DynamicContentProcessor
    {
        public override bool ovr_OutputContent()
        {
            BaseShape.OutputAllShapeInformation();

            return true;
        }

        public override bool ovr_ProcessType(Type type)
        {
            if (!typeof(BaseShape).IsAssignableFrom(type))
                return false;

            if (!type.IsDefined(typeof(RegisterShapeAttribute)))
                return false;

            RegisterShapeAttribute attr = (RegisterShapeAttribute)type.GetCustomAttribute(typeof(RegisterShapeAttribute), false);

            BaseShape.RegisterShape(attr.Name, type);

            return true;
        }
    }
}
