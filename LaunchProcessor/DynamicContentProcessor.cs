using System;

namespace LaunchLoader
{
    public abstract class DynamicContentProcessor
    {
        public bool ProcessType(Type type)
        {
            return ovr_ProcessType(type);
        }

        public bool OutputContent()
        {
            return ovr_OutputContent();
        }

        public abstract bool ovr_ProcessType(Type type);

        public abstract bool ovr_OutputContent();
    }
}
