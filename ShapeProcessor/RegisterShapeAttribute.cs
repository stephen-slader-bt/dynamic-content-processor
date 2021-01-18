using System;

namespace ShapeProcessor
{
    public sealed class RegisterShapeAttribute : Attribute
    {
        public RegisterShapeAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
