using System;

namespace LaunchProcessor.OutputClasses
{
    public sealed class RegisterOutputAttribute : Attribute
    {
        public RegisterOutputAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
